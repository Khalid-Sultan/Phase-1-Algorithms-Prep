using System;
using System.Collections.Generic;
using System.Text;

namespace Day_29
{
    class MinimumCost
    {
        static int mctFromLeafValues(int[] arr)
        {
            Array.Sort(arr);

            int sum = arr[arr.Length - 1] * arr[arr.Length - 2];

            if (arr.Length >= 3)
            {
                for (int i = arr.Length - 2; i > 0; i--)
                {
                    sum += arr[i] * arr[i - 1];
                }
            }
            return sum;
        }
        //static void Main(string[] args)
        //{
        //    int[] a = new int[] { 6,2,4};
        //    Console.WriteLine(mctFromLeafValues(a));
        //}
    }
}
