using System;
using System.Collections.Generic;
using System.Text;

namespace Day_29
{
    class AbsoluteValueMax
    {
        static int MaxAbsValExpr(int[] arr1, int[] arr2)
        {
            int min_arr1 = 0;
            int max_arr1 = 0;

            int min_arr2 = 0;
            int max_arr2 = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] <= arr1[min_arr1])
                {
                    int temp_1 = Math.Abs(arr1[max_arr1] - arr1[min_arr1]) + Math.Abs(arr2[max_arr1] - arr2[min_arr1]) + Math.Abs(max_arr1 - min_arr1);
                    int temp_2 = Math.Abs(arr1[max_arr1] - arr1[i]) + Math.Abs(arr2[max_arr1] - arr2[i]) + Math.Abs(max_arr1 - i);
                    if (temp_1 < temp_2)
                    {
                        min_arr1 = i;
                    }
                }
                if (arr1[i] >= arr1[max_arr1])
                {
                    int temp_1 = Math.Abs(arr1[max_arr1] - arr1[min_arr1]) + Math.Abs(arr2[max_arr1] - arr2[min_arr1]) + Math.Abs(max_arr1 - min_arr1);
                    int temp_2 = Math.Abs(arr1[i] - arr1[min_arr1]) + Math.Abs(arr2[i] - arr2[min_arr1]) + Math.Abs(i - min_arr1);
                    if (temp_1 < temp_2)
                    {
                        max_arr1 = i;
                    }
                }
                if (arr2[i] <= arr2[min_arr2])
                {
                    int temp_1 = Math.Abs(arr1[max_arr2] - arr1[min_arr2]) + Math.Abs(arr2[max_arr2] - arr2[min_arr2]) + Math.Abs(max_arr2 - min_arr2);
                    int temp_2 = Math.Abs(arr1[max_arr2] - arr1[i]) + Math.Abs(arr2[max_arr2] - arr2[i]) + Math.Abs(max_arr2 - i);
                    if (temp_1 < temp_2)
                    {
                        min_arr2 = i;
                    }
                }
                if (arr2[i] >= arr2[max_arr2])
                {
                    int temp_1 = Math.Abs(arr1[max_arr2] - arr1[min_arr2]) + Math.Abs(arr2[max_arr2] - arr2[min_arr2]) + Math.Abs(max_arr2 - min_arr2);
                    int temp_2 = Math.Abs(arr1[i] - arr1[min_arr2]) + Math.Abs(arr2[i] - arr2[min_arr2]) + Math.Abs(i - min_arr2);
                    if (temp_1 < temp_2)
                    {
                        max_arr2 = i;
                    }
                }
            }

            int value_1 = Math.Abs(arr1[max_arr1] - arr1[min_arr1]) + Math.Abs(arr2[max_arr1] - arr2[min_arr1]) + Math.Abs(max_arr1 - min_arr1);
            int value_2 = Math.Abs(arr1[max_arr2] - arr1[min_arr2]) + Math.Abs(arr2[max_arr2] - arr2[min_arr2]) + Math.Abs(max_arr2 - min_arr2);
            return Math.Max(value_1, value_2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxAbsValExpr(new int[] { 1, 2, 3, 4 }, new int[] { -1, 4, 5, 6 }));
            Console.WriteLine(MaxAbsValExpr(new int[] { 1, -2, -5, 0, 10 }, new int[] { 0, -2, -1, -7, -4 }));
            Console.WriteLine(MaxAbsValExpr(new int[] { -1, 2, -3, -4 }, new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(MaxAbsValExpr(new int[] { -1, -4 }, new int[] { 1, 2 }));
            Console.WriteLine(MaxAbsValExpr(new int[] { 10, 5, 2, -1, 5, 1 }, new int[] { -5, -4, 2, 9, -8, -5 }));
            Console.WriteLine(MaxAbsValExpr(new int[] { 2, 2, 6, 1, -7, -1, -7 }, new int[] { 6, 1, -2, -10, -7, -6, -10 }));

            Console.WriteLine(MaxAbsValExpr(new int[] { -9, 0, -5, -7, 10, 6, 1, -8, -4 }, new int[] { 7, 0, -5, -4, 7, 8, 1, -7, 6 }));
        }


    }
}
