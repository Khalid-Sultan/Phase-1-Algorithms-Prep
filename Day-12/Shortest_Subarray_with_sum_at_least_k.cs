using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12
{
    class Shortest_Subarray_with_sum_at_least_k
    {
        public int ShortestSubarray(int[] A, int target) {
            int[] result = new int[A.Length];

            int sum = 0;
            int start = A.Length - 1;
            result[A.Length - 1] = 1;

            for (int i = A.Length - 1; i > 0; i--) {
                result[i - 1] = 1;
                sum += A[i];
                if (sum <= 0) { 
                    result[i - 1] = start - i + 1;
                } else {
                    start = i;
                    sum = 0;
                }
            }

            start = 0;
            int end = 0;
            sum = 0;
            int min = int.MaxValue;
            while (end < A.Length) {
                sum += A[end++];
                while (start <= end && sum >= target) {
                    min = Math.Min(end - start, min);
                    for (int j = start; j < start + result[start]; j++) { 
                        sum -= A[j];
                    }
                    start = start + result[start];
                }
                if (sum <= 0) {
                    start = end;
                    sum = 0;
                }
            }

            return min == int.MaxValue ? -1 : min;
        }
    }
}
