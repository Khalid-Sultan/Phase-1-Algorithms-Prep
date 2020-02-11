using System;
using System.Collections.Generic;
using System.Text;

namespace Day_32
{
    class Reduce_Size
    {
        static int MinSetSize(int[] arr)
        {
            SortedDictionary<int, int> keyValuePairs = new SortedDictionary<int, int>();
            foreach(int i in arr)
            {
                if (keyValuePairs.ContainsKey(i))
                {
                    keyValuePairs[i]++;
                }
                else
                {
                    keyValuePairs.Add(i, 1);
                }
            }
            List<int> values = new List<int>(keyValuePairs.Values);
            values.Sort();

            int counter = 0;
            int size = arr.Length;
            for(int i= values.Count-1; i>=0; i--)
            {
                if (size <= arr.Length / 2)
                {
                    break;
                }
                size -= values[i];
                counter++;
            }
            return counter;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(MinSetSize(new int[] { 3, 3, 3, 3, 5, 5, 5, 2, 2, 7 }));
        //    Console.WriteLine(MinSetSize(new int[] { 7, 7, 7, 7, 7, 7 }));
        //    Console.WriteLine(MinSetSize(new int[] { 1, 9 }));
        //    Console.WriteLine(MinSetSize(new int[] { 1000, 1000, 3, 7 }));
        //    Console.WriteLine(MinSetSize(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        //}
    }
}
