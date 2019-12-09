using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_12
{
    class Task_Scheduler
    {
        public int LeastInterval(char[] tasks, int n)
        {
            Dictionary<char, int> counter = new Dictionary<char, int>();
            foreach (char c in tasks)
            {
                try
                {
                    counter[c]++;
                }
                catch
                {
                    counter.Add(c, 1);
                }
            }
            var ordered = counter.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int intervals = 0;
            while (ordered.Keys.Count > 0)
            {
                char[] keys = ordered.Keys.ToArray();
                int index = 0;
                while (index <= n)
                {
                    if (ordered[ordered.Keys.ToArray()[0]] == 0)
                    {
                        ordered.Remove(ordered.Keys.ToArray()[0]);
                        break;
                    }
                    if (index < keys.Length && ordered[keys[index]] > 0)
                        ordered[keys[index]]--;
                    intervals++;
                    index++;
                }
                ordered = ordered.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            }
            return intervals;

        }
    }
}
