using System;
using System.Collections.Generic;
using System.Text;

namespace Day_37
{
    class Maximum_Number_Of_Events
    {
        static int MaxEvents(int[][] events)
        {
            HashSet<int> event_counter = new HashSet<int>();
            List<int[]> ls = new List<int[]>();
            foreach(int[] i in events)
            {
                ls.Add(i);
            }
            ls.Sort(delegate (int[] c1, int[] c2) { return c1[1].CompareTo(c2[1]); });

            foreach(int[] i in ls)
            {
                for(int j = i[0]; j<=i[1]; j++)
                {
                    if (event_counter.Contains(j))
                    {
                        continue;
                    }
                    event_counter.Add(j);
                    break;
                }
            }

            return event_counter.Count;
        }
        //static void Main(String[] args)
        //{
        //    Console.WriteLine(MaxEvents(
        //        new int[][]
        //        {
        //            new int[]{1, 2},
        //            new int[]{2, 3},
        //            new int[]{3, 4},
        //        }
        //    ));
        //    Console.WriteLine(MaxEvents(
        //        new int[][]
        //        {
        //            new int[]{1, 2},
        //            new int[]{2, 3},
        //            new int[]{3, 4},
        //            new int[]{1, 2},
        //        }
        //    ));
        //    Console.WriteLine(MaxEvents(
        //        new int[][]
        //        {
        //            new int[]{1, 4},
        //            new int[]{4, 4},
        //            new int[]{2, 2},
        //            new int[]{3, 4},
        //            new int[]{1, 1},
        //        }
        //    ));
        //    Console.WriteLine(MaxEvents(
        //        new int[][]
        //        {
        //            new int[]{1, 10000},
        //        }
        //    ));
        //    Console.WriteLine(MaxEvents(
        //        new int[][]
        //        {
        //            new int[]{1, 1},
        //            new int[]{1, 2},
        //            new int[]{1, 3},
        //            new int[]{1, 4},
        //            new int[]{1, 5},
        //            new int[]{1, 6},
        //            new int[]{1, 7},
        //        }
        //    ));
        //    Console.WriteLine(MaxEvents(
        //        new int[][]
        //        {
        //            new int[]{1, 2},
        //            new int[]{1, 2},
        //            new int[]{3, 3},
        //            new int[]{1, 5},
        //            new int[]{1, 5},
        //        }
        //    ));
        //    Console.WriteLine(MaxEvents(
        //        new int[][]
        //        {
        //            new int[]{1, 3},
        //            new int[]{1, 3},
        //            new int[]{1, 3},
        //            new int[]{3, 4},
        //        }));
        //}
    }
}
