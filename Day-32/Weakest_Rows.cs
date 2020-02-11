using System;
using System.Collections.Generic;
using System.Text;

namespace Day_32
{
    class Weakest_Rows
    {
        static int[] KWeakestRows(int[][] mat, int k)
        {
            SortedDictionary<int, SortedSet<int>> keyValuePairs = new SortedDictionary<int, SortedSet<int>>();

            for (int row_counter = 0; row_counter < mat.Length; row_counter++)
            {
                int[] row = mat[row_counter];

                int counter = 0;
                foreach (int i in row)
                {
                    if (i == 1) counter++;
                }
                if (keyValuePairs.ContainsKey(counter))
                {
                    keyValuePairs[counter].Add(row_counter);
                }
                else
                {
                    SortedSet<int> pairs = new SortedSet<int>();
                    pairs.Add(row_counter);
                    keyValuePairs.Add(counter, pairs);
                }
            }

            int temp_counter = 0;
            int[] result = new int[k];
            foreach (int key in keyValuePairs.Keys)
            {
                if (temp_counter == k)
                {
                    return result;
                }
                foreach (int val in keyValuePairs[key])
                {
                    if (temp_counter == k)
                    {
                        return result;
                    }
                    result[temp_counter] = val;
                    temp_counter++;
                }
            }
            return result;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(KWeakestRows(new int[][] {
        //        new int[] { 1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0 },
        //        new int[] { 1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1,1, 1, 1, 1},
        //        new int[] { 1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1,1, 0, 0, 1},
        //        new int[] { 1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0,1, 0, 0, 0},
        //    }, 2));
        //}

    }
}
