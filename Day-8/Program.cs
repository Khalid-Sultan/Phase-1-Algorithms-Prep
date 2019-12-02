using System;
using System.Collections.Generic;

namespace Day_8
{
    class Program
    {
        /*
        Given an array A, we can perform a pancake flip: We choose some positive integer k <= A.length, 
        then reverse the order of the first k elements of A.  
        We want to perform zero or more pancake flips (doing them one after another in succession) to sort the 
        array A.
        Return the k-values corresponding to a sequence of pancake flips that sort A.  
        Any valid answer that sorts the array within 10 * A.length flips will be judged as correct.

        Example 1:

        Input: [3,2,4,1]
        Output: [4,2,4,3]
        Explanation: 
        We perform 4 pancake flips, with k values 4, 2, 4, and 3.
        Starting state: A = [3, 2, 4, 1]
        After 1st flip (k=4): A = [1, 4, 2, 3]
        After 2nd flip (k=2): A = [4, 1, 2, 3]
        After 3rd flip (k=4): A = [3, 2, 1, 4]
        After 4th flip (k=3): A = [1, 2, 3, 4], which is sorted. 
        Example 2:

        Input: [1,2,3]
        Output: []
        Explanation: The input is already sorted, so there is no need to flip anything.
        Note that other answers, such as [3, 3], would also be accepted.
 

        Note:

        1 <= A.length <= 100
        A[i] is a permutation of [1, 2, ..., A.length]        
        */
        static void flipToFirst(int[] A, int maximum)
        {
            Array.Reverse(A, 0, maximum);
        }
        static void flipToLast(int[] A, int maximum, int i)
        {
            Array.Reverse(A, A.Length-i-1, i);
        }
        static void addToMax(int[] max_allowed, int shifted, int j)
        {
            max_allowed[j] = shifted;
        }
        static IList<int> PancakeSort(int[] A)
        {
            int maximum = A.length;
            int[] max_allowed = new int[maxi];
            for (int j = 0; j < A.Length; j++)
            {
                int max_idx = 0;
                int largest = A[0];
                for (int i = 0; i < A.Length; i++)
                {
                    if (largest < A[i])
                    {
                        max_idx = i;
                        largest = A[i];
                    }
                }
                int shifted = flipToFirst(A, max_idx);
                shifted = flipToLast(A, maximum, j);
            }
            return A;
        }
        static void Main(string[] args)
        {
            int[] citations = { 3, 2, 4, 1 };
            Console.WriteLine(PancakeSort(citations));
        }
    }
}
