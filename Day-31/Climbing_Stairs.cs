using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Climbing_Stairs
    {
        public class Solution
        {
            public int ClimbStairs(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                int[] saved = new int[n + 1];
                saved[1] = 1;
                saved[2] = 2;
                for (int i = 3; i <= n; i++)
                {
                    saved[i] = saved[i - 1] + saved[i - 2];
                }
                return saved[n];
            }
        }
    }
}
