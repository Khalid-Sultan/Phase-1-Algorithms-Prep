using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16
{
    class N_th_Tribonacci_Number
    {
        static int[] memoized = new int[38];
        static int Tribonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;

            //if (memoized[n] == 0) memoized[n] = Tribonacci(n);
            if (memoized[n - 1] == 0) memoized[n - 1] = Tribonacci(n - 1);
            //if (memoized[n - 2] == 0) memoized[n - 2] = Tribonacci(n - 2);
            //if (memoized[n - 3] == 0) memoized[n - 3] = Tribonacci(n - 3);

            return memoized[n] + memoized[n - 1] + memoized[n - 2];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Tribonacci(4));
        }

    }
}
