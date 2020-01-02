using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12
{
    class Shortest_Subarray_with_sum_at_least_k
    {
        public static int ShortestSubarray(int[] A, int K)
        {
            LinkedList<int> linked_list = new LinkedList<int>();
            int[] temp = new int[A.Length + 1];

            temp[0] = 0;
            for (int i = 0; i < A.Length; i++) temp[i + 1] = A[i] + temp[i];


            int result = int.MaxValue;


            for (int i = 0; i < temp.Length; i++)
            {
                while (linked_list.Count > 0 && temp[linked_list.Last.Value] >= temp[i]) linked_list.RemoveLast();

                linked_list.AddLast(i);

                while (linked_list.Count > 1 && temp[i] - temp[linked_list.First.Next.Value] >= K) linked_list.RemoveFirst();

                if (i > 0 && temp[i] - temp[linked_list.First.Value] >= K)
                {
                    result = Math.Min(result, i - linked_list.First.Value);
                }

            }

            return int.MaxValue == result ? -1 : result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ShortestSubarray(new int[] { 1 }, 1));
            Console.WriteLine(ShortestSubarray(new int[] { 1, 2 }, 4));
            Console.WriteLine(ShortestSubarray(new int[] { 2, -1, 2 }, 3));
        }
    }
}
