using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HDH
{
    internal class PageResult
    {
        #region khai bao bien
        private int[,] snapshot;
        private List<int> pages;
        private List<int> replacedPages;
        private int faults;
        private int frameCount;
        #endregion

        #region get, set, khoi tao
        public int GetFaults()
        {
            return faults;
        }

        public int GetframeCount()
        {
            return frameCount;
        }

        public void SetframeCount(int value)
        {
            frameCount = value;
        }

        public PageResult()
        {
            pages = new List<int>();
            replacedPages = new List<int>();
            frameCount = 0;
            faults = 0;
        }

        public int[,] GetSnapshot()
        {
            return snapshot;
        }

        public void SetSnapshot(int[,] value)
        {
            snapshot = value;
        }

        public List<int> GetPages()
        {
            return pages;
        }

        public void SetPages(List<int> value)
        {
            pages = value;
        }

        public List<int> GetReplacedPages()
        {
            return replacedPages;
        }

        public void SetReplacedPages(List<int> value)
        {
            replacedPages = value;
        }

        public void atpages(int value)
        {
            pages.Add(value);
        }

        public void setpagesi(int i, int value)
        {
            pages[i] = value;
        }
        #endregion

        public void RunOPT()
        {
            faults = 0;
            replacedPages.Clear();
            List<int> frameList = new List<int>();
            snapshot = new int[frameCount, pages.Count];

            for (int i = 0; i < pages.Count; i++)
            {
                int current = pages[i];

                if (frameList.Contains(current))
                {
                    replacedPages.Add(-1);
                }
                else
                {
                    if (frameList.Count < frameCount)
                    {
                        frameList.Add(current);
                        replacedPages.Add(-1);
                    }
                    else
                    {
                        faults++;
                        int indexToReplace = -1;
                        int farthest = -1;

                        for (int j = 0; j < frameList.Count; j++)
                        {
                            int nextUse = pages.Skip(i + 1).ToList().IndexOf(frameList[j]);

                            if (nextUse == -1)
                            {
                                indexToReplace = j;
                                break;
                            }
                            else if (nextUse > farthest)
                            {
                                farthest = nextUse;
                                indexToReplace = j;
                            }
                        }

                        replacedPages.Add(frameList[indexToReplace]);
                        frameList[indexToReplace] = current;
                    }
                }

                for (int f = 0; f < frameCount; f++)
                {
                    snapshot[f, i] = f < frameList.Count ? frameList[f] : -1;
                }
            }
        }

        public void RunLRU()
        {
            faults = 0;
            replacedPages.Clear();
            snapshot = new int[frameCount, pages.Count];
            List<int> frameList = new List<int>();
            Dictionary<int, int> lastUsed = new Dictionary<int, int>();

            for (int i = 0; i < pages.Count; i++)
            {
                int current = pages[i];

                if (frameList.Contains(current))
                {
                    replacedPages.Add(-1);
                }
                else
                {
                    if (frameList.Count < frameCount)
                    {
                        frameList.Add(current);
                        replacedPages.Add(-1);
                    }
                    else
                    {
                        faults++;
                        int lruIndex = -1;
                        int oldestUse = int.MaxValue;

                        for (int j = 0; j < frameList.Count; j++)
                        {
                            int pageInFrame = frameList[j];
                            int lastTimeUsed = lastUsed.ContainsKey(pageInFrame) ? lastUsed[pageInFrame] : -1;

                            if (lastTimeUsed < oldestUse)
                            {
                                oldestUse = lastTimeUsed;
                                lruIndex = j;
                            }
                        }

                        replacedPages.Add(frameList[lruIndex]);
                        frameList[lruIndex] = current;
                    }
                }

                lastUsed[current] = i;

                for (int f = 0; f < frameCount; f++)
                {
                    snapshot[f, i] = f < frameList.Count ? frameList[f] : -1;
                }
            }
        }

        public void RunFIFO()
        {
            faults = 0;
            replacedPages.Clear();
            snapshot = new int[frameCount, pages.Count];
            Queue<int> frameQueue = new Queue<int>();
            List<int> frameList = new List<int>();

            for (int i = 0; i < pages.Count; i++)
            {
                int current = pages[i];

                if (frameList.Contains(current))
                {
                    replacedPages.Add(-1);
                }
                else
                {
                    if (frameList.Count < frameCount)
                    {
                        frameList.Add(current);
                        frameQueue.Enqueue(current);
                        replacedPages.Add(-1);
                    }
                    else
                    {
                        faults++;
                        int oldest = frameQueue.Dequeue();
                        int index = frameList.IndexOf(oldest);
                        replacedPages.Add(oldest);
                        frameList[index] = current;
                        frameQueue.Enqueue(current);
                    }
                }

                for (int f = 0; f < frameCount; f++)
                {
                    snapshot[f, i] = f < frameList.Count ? frameList[f] : -1;
                }
            }
        }

        public void RunCLOCK(ref List<int> clockPointerHistory, ref List<List<bool>> usebitHistory)
        {
            faults = 0;
            replacedPages.Clear();
            snapshot = new int[frameCount, pages.Count];
            clockPointerHistory.Clear();
            usebitHistory.Clear();

            List<int> frameList = new List<int>();
            List<bool> referenceBits = new List<bool>();
            int pointer = 0;

            for (int i = 0; i < pages.Count; i++)
            {
                int current = pages[i];

                if (frameList.Contains(current))
                {
                    int index = frameList.IndexOf(current);
                    referenceBits[index] = true;
                    replacedPages.Add(-1);
                }
                else
                {
                    if (frameList.Count < frameCount)
                    {
                        frameList.Add(current);
                        referenceBits.Add(true);
                        replacedPages.Add(-1);

                        pointer = (pointer + 1) % frameCount;
                        clockPointerHistory.Add(pointer);
                    }
                    else
                    {
                        faults++;
                        while (true)
                        {
                            if (!referenceBits[pointer])
                            {
                                replacedPages.Add(frameList[pointer]);
                                frameList[pointer] = current;
                                referenceBits[pointer] = true;

                                pointer = (pointer + 1) % frameCount;
                                clockPointerHistory.Add(pointer);
                                break;
                            }
                            else
                            {
                                referenceBits[pointer] = false;
                                pointer = (pointer + 1) % frameCount;
                            }
                        }
                    }
                }

                if (clockPointerHistory.Count <= i)
                {
                    clockPointerHistory.Add(pointer);
                }

                usebitHistory.Add(new List<bool>(referenceBits));

                for (int f = 0; f < frameCount; f++)
                {
                    snapshot[f, i] = f < frameList.Count ? frameList[f] : -1;
                }
            }
        }
    }
}
