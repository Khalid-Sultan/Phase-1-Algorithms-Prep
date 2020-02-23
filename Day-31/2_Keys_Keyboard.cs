using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class _2_Keys_Keyboard
    {
        public int MinSteps(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            if (n == 2)
            {
                return n;
            }
            int min = 2;
            int temp = 0;
            while (min < n)
            {
                if (n % min == 0)
                {
                    temp = MinSteps(n / min);
                    break;
                }
                min++;
            }
            return temp + min;
        }
    }
}
