using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Integer_Break
    {
        public class Solution
        {
            public int IntegerBreak(int n)
            {
                if (n < 2)
                    return 0;
                if (n == 2)
                    return 1;
                if (n == 3)
                    return 2;
                int pro = 1;
                while (n > 4)
                {
                    pro *= 3;
                    n -= 3;
                }
                pro *= n;

                return pro;
            }
        }
    }
}
