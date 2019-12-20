using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16
{
    class N_th_Tribonacci_Number
    {
        int[] memoized = new int[37];
        public int Tribonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            if (memoized[n - 1] == 0) memoized[n - 1] = Tribonacci(n - 1);
            if (memoized[n - 2] == 0) memoized[n - 2] = Tribonacci(n - 2);
            if (memoized[n - 3] == 0) memoized[n - 3] = Tribonacci(n - 3);
            return memoized[n - 1] + memoized[n - 2] + memoized[n - 3];
        }
    }
}
