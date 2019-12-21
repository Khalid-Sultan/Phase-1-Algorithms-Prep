using System;
using System.Collections.Generic;
using System.Text;

namespace Day_19
{
    class Peek_In_A_Mountain_Array
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            int min = A[0];
            int minIndex = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    break;
                }
                minIndex++;
                min = A[i];
            }
            return minIndex;
        }

    }
}
