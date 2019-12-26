using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_19
{
    class Top_K_Frequent_Elements
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                try
                {
                    d[i]++;
                }
                catch
                {
                    d.Add(i, 1);
                }
            }

            var sorted_d = d.OrderByDescending(x => x.Value);

            List<int> result = new List<int>();
            foreach (var item in sorted_d)
            {
                result.Add(item.Key);
                if (result.Count == k)
                {
                    break;
                }
            }

            return result;
        }

    }
}
