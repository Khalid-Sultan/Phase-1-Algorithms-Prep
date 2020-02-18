using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Unique_Binary_Search_Trees
    {
        public class Solution
        {
            public int NumTrees(int n)
            {
                int[] memo = new int[n + 1];
                memo[0] = 1;
                memo[1] = 1;
                for (int i = 2; i <= n; ++i)
                {
                    for (int j = 1; j <= i; ++j)
                    {
                        memo[i] += memo[j - 1] * memo[i - j];
                    }
                }
                return memo[n];
            }
        }
    }
}
