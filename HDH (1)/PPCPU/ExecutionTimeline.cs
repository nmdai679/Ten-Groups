using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDH
{
    internal class ExecutionTimeline
    {
        #region khai bao bien
        private string processName;
        private int startTime;
        private int endTime;
        #endregion

        #region get, set, khoi tao
        public ExecutionTimeline(string processName, int startTime, int endTime)
        {
            this.processName = processName;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public string GetProcessName()
        {
            return processName;
        }

        public void SetProcessName(string value)
        {
            processName = value;
        }

        public int GetStartTime()
        {
            return startTime;
        }

        public void SetStartTime(int value)
        {
            startTime = value;
        }

        public int GetEndTime()
        {
            return endTime;
        }

        public void SetEndTime(int value)
        {
            endTime = value;
        }
        #endregion
    }
}
