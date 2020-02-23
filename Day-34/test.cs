using System;
using System.Collections.Generic;
using System.Text;

namespace Day_34
{
    class test
    {
        static int MaxTurbulenceSize(int[] A)
        {
            if ((A.Length==1) || A.Length == 2 && A[0]==A[1])
            {
                return 1;
            }
            if (A.Length <= 2)
            {
                return A.Length;
            }

            int result = 0;

            bool prev_sequence = false;
            for (int i = 1; i < A.Length; i++)
            {
                int temp = 2;
                if (A[i] == A[i - 1])
                {
                    temp--;
                }
                prev_sequence = A[i] > A[i - 1];
                int start = i+1;
                while (start < A.Length)
                {
                    if ((prev_sequence && A[start] < A[start - 1] || !prev_sequence && A[start] > A[start - 1]))
                    {
                        prev_sequence = !prev_sequence;
                        temp++;
                    }
                    else
                    {
                        result = Math.Max(temp, result);
                        i = start-1;
                        break;
                    }
                    start++;
                }
                result = Math.Max(temp, result);
            }
            return result;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(MaxTurbulenceSize(new int[] { 9, 9 }));
        //    Console.WriteLine(MaxTurbulenceSize(new int[] {9,4,2,10,7,8,1,11,9, 9, 4, 2, 10, 7, 8, 8, 1, 9, 9, 4, 2, 10, 7, 8, 8, 1, 9, 9, 4, 2, 10, 7, 8, 8, 1, 9, 9, 4, 2, 10, 7, 8, 8, 1, 9 }));
        //}
    }
}

