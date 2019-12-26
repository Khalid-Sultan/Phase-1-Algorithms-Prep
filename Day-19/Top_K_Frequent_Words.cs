using System;
using System.Collections.Generic;
using System.Text;

namespace Day_19
{
    class Top_K_Frequent_Words
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            foreach (string i in words)
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

            var result = new List<string>(
                (from pair in d
                 orderby pair.Value descending, pair.Key
                 select pair.Key).Take(k));

            return result;

        }

    }
}
