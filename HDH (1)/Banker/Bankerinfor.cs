using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDH
{
    internal class Bankerinfor
    {
        public int ProcessCount;
        public int ResourceCount;
        public int[,] Max;
        public int[,] Allocation;
        public int[] Available;
        public List<int[]> WorkHistory;
        private int[,] Need;

        public int[,] GetNeed()
        {
            return Need;
        }

        public void SetNeed(int[,] value)
        {
            Need = value;
        }

        public void CalculateNeed()
        {
            Need = new int[ProcessCount, ResourceCount];
            for (int i = 0; i < ProcessCount; i++)
            {
                for (int j = 0; j < ResourceCount; j++)
                {
                    Need[i, j] = Max[i, j] - Allocation[i, j];
                }
            }
        }

        public Bankerinfor()
        {
            ProcessCount = 0;
            ResourceCount = 0;
            Max = null;
            Allocation = null;
            Available = null;
            WorkHistory = new List<int[]>();
        }

        public void Init(int processCount, int resourceCount)
        {
            ProcessCount = processCount;
            ResourceCount = resourceCount;
            Max = new int[ProcessCount, ResourceCount];
            Allocation = new int[ProcessCount, ResourceCount];
            Available = new int[ResourceCount];
            WorkHistory = new List<int[]>();
        }

        public int GetProcessCount()
        {
            return ProcessCount;
        }

        public void SetProcessCount(int value)
        {
            ProcessCount = value;
        }

        public int GetResourceCount()
        {
            return ResourceCount;
        }

        public void SetResourceCount(int value)
        {
            ResourceCount = value;
        }

        public int[,] GetMax()
        {
            return Max;
        }

        public void SetMax(int[,] value)
        {
            Max = value;
        }

        public int[,] GetAllocation()
        {
            return Allocation;
        }

        public void SetAllocationAt(int row, int col, int value)
        {
            if (Allocation != null &&
                row >= 0 && row < Allocation.GetLength(0) &&
                col >= 0 && col < Allocation.GetLength(1))
            {
                Allocation[row, col] = value;
            }
        }

        public void SetAllocation(int[,] value)
        {
            Allocation = value;
        }

        public void SetAvailable(int[] value)
        {
            Available = value;
        }

        public void SetWorkHistory(List<int[]> value)
        {
            WorkHistory = value;
        }

        public int[] GetAvailable()
        {
            return Available;
        }

        public List<int[]> GetWorkHistory()
        {
            return WorkHistory;
        }

        public Bankerinfor(int processCount, int resourceCount, int[,] max, int[,] allocation, int[] available)
        {
            ProcessCount = processCount;
            ResourceCount = resourceCount;
            Max = max;
            Allocation = allocation;
            Available = available;
            WorkHistory = new List<int[]>();
        }

        public bool IsSafeState(out List<int> safeSequence)
        {
            safeSequence = new List<int>();
            WorkHistory.Clear();

            bool[] finish = new bool[ProcessCount];
            int[] work = new int[ResourceCount];
            Available.CopyTo(work, 0);

            while (safeSequence.Count < ProcessCount)
            {
                bool foundProcess = false;

                for (int i = 0; i < ProcessCount; i++)
                {
                    if (!finish[i])
                    {
                        bool canRun = true;

                        for (int j = 0; j < ResourceCount; j++)
                        {
                            int need = Max[i, j] - Allocation[i, j];
                            if (need > work[j])
                            {
                                canRun = false;
                                break;
                            }
                        }

                        if (canRun)
                        {
                            for (int j = 0; j < ResourceCount; j++)
                            {
                                work[j] += Allocation[i, j];
                            }

                            finish[i] = true;
                            safeSequence.Add(i);

                            int[] currentWork = new int[ResourceCount];
                            Array.Copy(work, currentWork, ResourceCount);
                            WorkHistory.Add(currentWork);

                            foundProcess = true;
                        }
                    }
                }

                if (!foundProcess)
                {
                    return false;
                }
            }

            return true;
        }

        public bool HandleRequest(int processIndex, int[] request, out List<int> safeSequence, out string message)
        {
            safeSequence = new List<int>();
            message = "";

            CalculateNeed(); 

            for (int i = 0; i < ResourceCount; i++)
            {
                if (request[i] > Need[processIndex, i])
                {
                    message = $"Yêu cầu vượt quá nhu cầu của tiến trình P{processIndex + 1}.";
                    return false;
                }

                if (request[i] > Available[i])
                {
                    message = "Không đủ tài nguyên để cấp phát ngay, tiến trình phải chờ.";
                    return false;
                }
            }

            for (int i = 0; i < ResourceCount; i++)
            {
                Available[i] -= request[i];
                Allocation[processIndex, i] += request[i];
                Need[processIndex, i] -= request[i];
            }

            if (IsSafeState(out safeSequence))
            {
                message = "Cấp phát thành công. Hệ thống vẫn AN TOÀN.";
                return true;
            }
            else
            {
                for (int i = 0; i < ResourceCount; i++)
                {
                    Available[i] += request[i];
                    Allocation[processIndex, i] -= request[i];
                    Need[processIndex, i] += request[i];
                }

                message = "Không thể cấp phát vì sẽ dẫn đến trạng thái không an toàn.";
                return false;
            }
        }

        public List<int> DetectDeadlock()
        {
            CalculateNeed(); 

            bool[] Finish = new bool[ProcessCount];
            int[] Work = new int[ResourceCount];
            Available.CopyTo(Work, 0);

            for (int i = 0; i < ProcessCount; i++)
            {
                bool isZero = true;
                for (int j = 0; j < ResourceCount; j++)
                {
                    if (Allocation[i, j] != 0)
                    {
                        isZero = false;
                        break;
                    }
                }
                Finish[i] = isZero;
            }

            bool found;
            do
            {
                found = false;
                for (int i = 0; i < ProcessCount; i++)
                {
                    if (!Finish[i])
                    {
                        bool canProceed = true;
                        for (int j = 0; j < ResourceCount; j++)
                        {
                            if (Need[i, j] > Work[j])
                            {
                                canProceed = false;
                                break;
                            }
                        }

                        if (canProceed)
                        {
                            for (int j = 0; j < ResourceCount; j++)
                                Work[j] += Allocation[i, j];

                            Finish[i] = true;
                            found = true;
                        }
                    }
                }
            } while (found);

            List<int> deadlocked = new List<int>();
            for (int i = 0; i < ProcessCount; i++)
                if (!Finish[i])
                    deadlocked.Add(i);

            return deadlocked;
        }
    }
}
