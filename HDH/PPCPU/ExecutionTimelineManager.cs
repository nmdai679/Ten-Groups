using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDH
{
    internal class ExecutionTimelineManager
    {
        private List<ExecutionTimeline> timelines;

        public ExecutionTimelineManager()
        {
            timelines = new List<ExecutionTimeline>();
        }

        public void AddTimeline(ExecutionTimeline timeline)
        {
            timelines.Add(timeline);
        }

        public bool RemoveTimeline(ExecutionTimeline timeline)
        {
            return timelines.Remove(timeline);
        }

        public List<ExecutionTimeline> GetAllTimelines()
        {
            return timelines;
        }

        public void ClearAll()
        {
            timelines.Clear();
        }

    }
}
