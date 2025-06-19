using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDH
{
    internal class ProcessManager
    {
        #region khai bao bien
        private List<ProcessInfo> processList;
        private double avgWaitingTime;
        private double avgTurnaroundTime;
        private double throughput;
        #endregion

        #region get, set, khoi tao, add, delete
        public ProcessManager()
        {
            processList = new List<ProcessInfo>();
        }

        public double GetAvgWaitingTime()
        {
            return avgWaitingTime;
        }

        public void SetAvgWaitingTime(double value)
        {
            avgWaitingTime = value;
        }

        public double GetAvgTurnaroundTime()
        {
            return avgTurnaroundTime;
        }

        public void SetAvgTurnaroundTime(double value)
        {
            avgTurnaroundTime = value;
        }

        public double GetThroughput()
        {
            return throughput;
        }

        public void SetThroughput(double value)
        {
            throughput = value;
        }
        
        public void AddProcess(ProcessInfo p)
        {
            processList.Add(p);
        }

        public bool DeleteProcessByName(string name)
        {
            var process = processList.FirstOrDefault(p => p.GetProcessName() == name);
            if (process != null)
            {
                processList.Remove(process);
                return true;
            }
            return false;
        }

        public List<ProcessInfo> GetAllProcesses()
        {
            return processList;
        }

        public void SortByArrivingTime()
        {
            processList = processList.OrderBy(p => p.GetArrivingTime()).ToList();
        }
        #endregion

        public List<ExecutionTimeline> RunFCFS()
        {
            List<ExecutionTimeline> timelines = new List<ExecutionTimeline>();

            if (processList.Count == 0)
                return timelines;

            SortByArrivingTime();

            int starttime = processList[0].GetArrivingTime();
            int firstStartTime = starttime;
            double totalWaitingTime = 0;
            double totalTurnaroundTime = 0;

            foreach (var process in processList)
            {
                if (starttime < process.GetArrivingTime())
                {
                    starttime = process.GetArrivingTime();
                }

                int endtime = starttime + process.GetBurstTime();
                int tat = endtime - process.GetArrivingTime();
                int wt = tat - process.GetBurstTime();

                process.SetTurnaroundTime(tat);
                process.SetWaitingTime(wt);

                totalWaitingTime += wt;
                totalTurnaroundTime += tat;

                timelines.Add(new ExecutionTimeline(process.GetProcessName(), starttime, endtime));

                starttime = endtime;
            }

            int n = processList.Count;
            SetAvgWaitingTime(totalWaitingTime / n);
            SetAvgTurnaroundTime(totalTurnaroundTime / n);
            SetThroughput((double)n / (starttime - firstStartTime));

            return timelines;
        }

        public List<ExecutionTimeline> RunSJF()
        {
            List<ExecutionTimeline> timelines = new List<ExecutionTimeline>();

            if (processList.Count == 0)
                return timelines;

            int n = processList.Count;
            int completed = 0;
            int currentTime = 0;
            double totalWT = 0;
            double totalTAT = 0;
            int firstStartTime = processList.Min(p => p.GetArrivingTime());

            List<ProcessInfo> executed = new List<ProcessInfo>();

            while (completed < n)
            {
                var readyQueue = processList
                    .Where(p => p.GetArrivingTime() <= currentTime && !executed.Contains(p))
                    .OrderBy(p => p.GetBurstTime())
                    .ThenBy(p => p.GetArrivingTime())
                    .ToList();

                if (readyQueue.Count == 0)
                {
                    currentTime++;
                    continue;
                }

                var process = readyQueue.First();

                int startTime = currentTime;
                int endTime = startTime + process.GetBurstTime();

                int tat = endTime - process.GetArrivingTime();
                int wt = tat - process.GetBurstTime();

                process.SetTurnaroundTime(tat);
                process.SetWaitingTime(wt);
                executed.Add(process);

                totalWT += wt;
                totalTAT += tat;

                timelines.Add(new ExecutionTimeline(process.GetProcessName(), startTime, endTime));

                currentTime = endTime;
                completed++;
            }

            SetAvgWaitingTime(totalWT / n);
            SetAvgTurnaroundTime(totalTAT / n);
            SetThroughput((double)n / (currentTime - firstStartTime));

            return timelines;
        }

        public List<ExecutionTimeline> RunSRTF()
        {
            List<ExecutionTimeline> timelines = new List<ExecutionTimeline>();

            if (processList.Count == 0)
                return timelines;

            var remainingTimes = processList.ToDictionary(p => p, p => p.GetBurstTime());
            var completed = new HashSet<ProcessInfo>();

            int currentTime = 0;
            double totalWT = 0, totalTAT = 0;
            string lastProcess = "";
            int segmentStartTime = currentTime;
            int firstStartTime = processList.Min(p => p.GetArrivingTime());

            while (completed.Count < processList.Count)
            {
                var readyQueue = processList
                    .Where(p => p.GetArrivingTime() <= currentTime && !completed.Contains(p))
                    .OrderBy(p => remainingTimes[p])
                    .ThenBy(p => p.GetArrivingTime())
                    .ToList();

                if (readyQueue.Count == 0)
                {
                    if (!string.IsNullOrEmpty(lastProcess))
                    {
                        timelines.Add(new ExecutionTimeline(lastProcess, segmentStartTime, currentTime));
                        lastProcess = "";
                    }

                    int nextArrival = processList
                        .Where(p => !completed.Contains(p) && p.GetArrivingTime() > currentTime)
                        .Select(p => p.GetArrivingTime())
                        .DefaultIfEmpty(currentTime + 1)
                        .Min();

                    currentTime = nextArrival;
                    segmentStartTime = currentTime;
                    continue;
                }

                var currentProcess = readyQueue.First();

                if (currentProcess.GetProcessName() != lastProcess)
                {
                    if (!string.IsNullOrEmpty(lastProcess))
                    {
                        timelines.Add(new ExecutionTimeline(lastProcess, segmentStartTime, currentTime));
                    }

                    segmentStartTime = currentTime;
                    lastProcess = currentProcess.GetProcessName();
                }

                remainingTimes[currentProcess]--;
                currentTime++;

                if (remainingTimes[currentProcess] == 0)
                {
                    completed.Add(currentProcess);

                    int tat = currentTime - currentProcess.GetArrivingTime();
                    int wt = tat - currentProcess.GetBurstTime();

                    currentProcess.SetTurnaroundTime(tat);
                    currentProcess.SetWaitingTime(wt);

                    totalTAT += tat;
                    totalWT += wt;
                }
            }

            if (!string.IsNullOrEmpty(lastProcess))
            {
                timelines.Add(new ExecutionTimeline(lastProcess, segmentStartTime, currentTime));
            }

            int n = processList.Count;
            SetAvgWaitingTime(totalWT / n);
            SetAvgTurnaroundTime(totalTAT / n);
            SetThroughput((double)n / (currentTime - firstStartTime));

            return timelines;
        }

        public List<ExecutionTimeline> RunRR(int quantum)
        {
            List<ExecutionTimeline> timelines = new List<ExecutionTimeline>();

            if (processList.Count == 0)
                return timelines;

            int currentTime = 0;
            int completed = 0;
            int firstStartTime = processList.Min(p => p.GetArrivingTime());
            int n = processList.Count;

            Queue<ProcessInfo> sourceQueue = new Queue<ProcessInfo>(processList.OrderBy(p => p.GetArrivingTime()));
            Queue<ProcessInfo> activeQueue = new Queue<ProcessInfo>();

            Dictionary<ProcessInfo, int> remainingTime = processList.ToDictionary(p => p, p => p.GetBurstTime());
            HashSet<ProcessInfo> arrived = new HashSet<ProcessInfo>();

            while (completed < n)
            {
                while (sourceQueue.Count > 0 && sourceQueue.Peek().GetArrivingTime() <= currentTime)
                {
                    var p = sourceQueue.Dequeue();
                    activeQueue.Enqueue(p);
                    arrived.Add(p);
                }

                if (activeQueue.Count == 0)
                {
                    currentTime++;
                    continue;
                }

                var process = activeQueue.Dequeue();
                int executeTime = Math.Min(quantum, remainingTime[process]);
                int startTime = currentTime;
                int endTime = startTime + executeTime;

                timelines.Add(new ExecutionTimeline(process.GetProcessName(), startTime, endTime));

                remainingTime[process] -= executeTime;
                currentTime += executeTime;

                if (remainingTime[process] > 0)
                {
                    while (sourceQueue.Count > 0 && sourceQueue.Peek().GetArrivingTime() < currentTime)
                    {
                        var p = sourceQueue.Dequeue();
                        activeQueue.Enqueue(p);
                        arrived.Add(p);
                    }

                    activeQueue.Enqueue(process);

                    while (sourceQueue.Count > 0 && sourceQueue.Peek().GetArrivingTime() == currentTime)
                    {
                        var p = sourceQueue.Dequeue();
                        activeQueue.Enqueue(p);
                        arrived.Add(p);
                    }
                }
                else
                {
                    while (sourceQueue.Count > 0 && sourceQueue.Peek().GetArrivingTime() <= currentTime)
                    {
                        var p = sourceQueue.Dequeue();
                        activeQueue.Enqueue(p);
                        arrived.Add(p);
                    }

                    int tat = currentTime - process.GetArrivingTime();
                    int wt = tat - process.GetBurstTime();
                    process.SetTurnaroundTime(tat);
                    process.SetWaitingTime(wt);
                    completed++;
                }
            }

            SetAvgWaitingTime(processList.Average(p => p.GetWaitingTime()));
            SetAvgTurnaroundTime(processList.Average(p => p.GetTurnaroundTime()));
            SetThroughput((double)n / (currentTime - firstStartTime));

            return timelines;
        }
    }
}
