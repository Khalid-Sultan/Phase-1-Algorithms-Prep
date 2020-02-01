using System;
using System.Collections.Generic;

namespace Day_27
{
    class UniqueOccurrences
    {
        public static bool UniqueOccurrence(int[] arr)
        {
            Dictionary<int, int> sorted = new Dictionary<int, int>();
            Dictionary<int, int> counter = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (sorted.ContainsKey(i))
                {
                    sorted[i]++;
                }
                else
                {
                    sorted.Add(i, 1);
                }
            }

            List<int> keys = new List<int>(sorted.Keys);
            foreach (int i in keys)
            {
                if (counter.ContainsKey(sorted[i])) return false;
                counter.Add(sorted[i], 1);
            }
            return true;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(UniqueOccurrences(new int[] { 1, 2, 2, 1, 1, 3}));
        //    Console.WriteLine(UniqueOccurrences(new int[] { 1, 2 }));
        //    Console.WriteLine(UniqueOccurrences(new int[] { 1}));
        //    Console.WriteLine(UniqueOccurrences(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }));
        //}

    }
}
