using System;
using System.Collections.Generic;
using System.Text;

namespace Day_33
{
    class Same_Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SplitArraySameAverage(new int[] { 1, 6, 1 }));
        }
        static bool check(int[] A, int leftSum, int leftNum, int startIndex)
        {
            if (leftNum == 0)
                return leftSum == 0;
            if ((A[startIndex]) > leftSum / leftNum)
                return false;
            for (int i = startIndex; i < A.Length - leftNum + 1; i++)
            {
                if (i > startIndex && A[i] == A[i - 1])
                    continue;
                if (check(A, leftSum - A[i], leftNum - 1, i + 1))
                    return true;
            }
            return false;
        }

        static bool SplitArraySameAverage(int[] A)
        {
            if (A.Length == 1)
            {
                return false;
            }
            int probable_sum = 0;
            foreach (int i in A)
            {
                probable_sum += i;
            }
            Array.Sort(A);
            // (sumOfA / lenA) == (sumOfB / lenB)
            // sumOfB == (sumOfA * lenB) / lenA
            for (int lenOfB = 1; lenOfB <= A.Length / 2; lenOfB++)
            {
                if ((probable_sum * lenOfB) % A.Length == 0)
                {
                    if (check(A, (probable_sum * lenOfB) / A.Length, lenOfB, 0))
                        return true;
                }
            }
            return false;
        }
    }
}
