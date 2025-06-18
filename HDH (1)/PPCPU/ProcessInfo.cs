using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDH
{
    internal class ProcessInfo
    {
        #region khai bao bien
        private string processName;
        private int burstTime;
        private int arrivingTime;
        private int waitingTime;
        private int turnaroundTime;
        #endregion

        #region get, set, khoi tao
        public ProcessInfo(string name, int burst, int arrive)
        {
            processName = name;
            burstTime = burst;
            arrivingTime = arrive;
            waitingTime = 0;
            turnaroundTime = 0;
        }

        public string GetProcessName()
        {
            return processName;
        }

        public void SetProcessName(string name)
        {
            processName = name;
        }

        public int GetBurstTime()
        {
            return burstTime;
        }

        public void SetBurstTime(int burst)
        {
            burstTime = burst;
        }

        public int GetArrivingTime()
        {
            return arrivingTime;
        }

        public void SetArrivingTime(int arrive)
        {
            arrivingTime = arrive;
        }

        public int GetWaitingTime()
        {
            return waitingTime;
        }

        public void SetWaitingTime(int waiting)
        {
            waitingTime = waiting;
        }

        public int GetTurnaroundTime()
        {
            return turnaroundTime;
        }

        public void SetTurnaroundTime(int turnaround)
        {
            turnaroundTime = turnaround;
        }
        #endregion

    }
}
