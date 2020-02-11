using System;
using System.Collections.Generic;
using System.Text;

namespace Day_32
{
    class Jump_Game
    {
        static int MaxJumps(int[] arr, int d, int counter, int[] result)
        {
            if (result[counter] != -1)
            {
                return result[counter];
            }
            for (int i = counter + 1, j = 0; j < d && i < arr.Length; i++, j++)
            {
                if (arr[counter] > arr[i])
                {
                    result[counter] = Math.Max(result[counter], 1 + MaxJumps(arr, d, i, result));
                }
                else
                {
                    break;
                }
            }
            for (int i = counter - 1, j = 0; j < d && i >= 0; i--, j++)
            {
                if (arr[counter] > arr[i])
                {
                    result[counter] = Math.Max(result[counter], 1 + MaxJumps(arr, d, i, result));
                }
                else
                {
                    break;
                }
            }
            result[counter] = Math.Max(result[counter], 1);
            return result[counter];
        }
        static int MaxJumps(int[] arr, int d)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = -1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = MaxJumps(arr, d, i, result);
            }

            Array.Sort(result);
            return result[result.Length - 1];
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(MaxJumps(new int[] { 6, 4, 14, 6, 8, 13, 9, 7, 10, 6, 12 }, 2));
        //    Console.WriteLine(MaxJumps(new int[] { 3, 3, 3, 3, 3 }, 3));
        //    Console.WriteLine(MaxJumps(new int[] { 7, 6, 5, 4, 3, 2, 1 }, 1));
        //    Console.WriteLine(MaxJumps(new int[] { 7, 1, 7, 1, 7, 1 }, 2));
        //    Console.WriteLine(MaxJumps(new int[] { 66 }, 1));
        //}

    }
}
