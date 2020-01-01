using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class Factorial_Trailing_Zeros
    {
        public int TrailingZeroes(int n)
        {
            if (n <= 0) return 0;
            int count = 0;
            while (n > 0)
            {
                count += n / 5;
                n /= 5;
            }

            return count;
        }
    }
}
