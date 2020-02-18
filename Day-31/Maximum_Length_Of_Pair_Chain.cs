using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Maximum_Length_Of_Pair_Chain
    {
        static int FindLongestChain(int[][] pairs)
        {
            int result = 0;
            List<int[]> ls = new List<int[]>();
            foreach(int[] pair in pairs)
            {
                ls.Add(pair);
            }
            ls.Sort(delegate (int[] c1, int[] c2) { return c1[1].CompareTo(c2[1]); });

            for(int i = 0; i<ls.Count; i++)
            {
                int currentCount = 1;
                int[] currentPair = ls[i];
                for(int j = i+1; j<ls.Count; j++)
                {
                    if (currentPair[1] < ls[j][0])
                    {
                        currentCount++;
                        currentPair[0] = ls[j][0];
                        currentPair[1] = ls[j][1];
                    }
                }
                if (currentCount > result)
                {
                    result = currentCount;
                }
            }
            return result;
        }
        //static void Main(String[] args)
        //{
        //    Console.WriteLine(FindLongestChain(new int[][] {
        //        new int[] { 1, 2 },
        //        new int[] { 1, 2 },
        //        new int[] { 1, 2 }
        //    }));
        //}
    }
}
