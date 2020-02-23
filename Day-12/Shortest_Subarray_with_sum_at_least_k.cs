using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12
{
    class Shortest_Subarray_with_sum_at_least_k
    {
        public static int ShortestSubarray(int[] A, int K)
        {
            int[] sum = new int[A.Length + 1];
            int[] deque = new int[A.Length + 1];
            for (int i = 0; i <= A.Length; i++)
            {
                sum[i] = 0;
                deque[i] = 0;
            }
            for (int i = 0; i < A.Length; i++)
            {
                sum[i + 1] = sum[i] + A[i];
            }

            int start = 0;
            int end = 0;
            int ans = A.Length + 1;

            for (int i = 0; i <= A.Length; i++)
            {
                while (start < end)
                {
                    if (sum[i] - sum[deque[start]] < K)
                    {
                        break;
                    }
                    ans = Math.Min(ans, i - deque[start]);
                    start += 1;
                }
                while (start < end)
                {
                    if (sum[i] > sum[deque[end - 1]])
                    {
                        break;
                    }
                    end -= 1;
                }
                deque[end] = i;
                end += 1;
            }
            if (ans == A.Length + 1)
            {
                return -1;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ShortestSubarray(new int[] { 1 }, 1));
            Console.WriteLine(ShortestSubarray(new int[] { 1,2 }, 4));
            Console.WriteLine(ShortestSubarray(new int[] { 2,-1,2 }, 3));
            Console.WriteLine(ShortestSubarray(new int[] { 7, -5, 3, -2, 8, -6, 7 },9));
        }
    }
}
