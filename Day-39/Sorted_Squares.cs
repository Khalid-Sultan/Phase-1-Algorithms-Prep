using System;
using System.Collections.Generic;
using System.Text;

namespace Day_39
{
    class Sorted_Squares
    {
        public int[] SortedSquares(int[] A)
        {
            List<int> list = new List<int>();
            foreach (int i in A)
            {
                list.Add(i * i);
            }
            list.Sort();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = list[i];
            }
            return A;
        }
    }
}
