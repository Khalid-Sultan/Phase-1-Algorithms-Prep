using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Longest_Palindromic_Sequence
    {
        public class Solution
        {
            public int LongestPalindromeSubseq(string s)
            {
                if (s == null || s.Length == 0)
                {
                    return 0;
                }
                int[][] memo = new int[s.Length][];
                for (int i = 0; i < s.Length; i++)
                {
                    memo[i] = new int[s.Length];
                }

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    memo[i][i] = 1;
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            memo[i][j] = memo[i + 1][j - 1] + 2;
                        }
                        else
                        {
                            memo[i][j] = Math.Max(memo[i + 1][j], memo[i][j - 1]);
                        }
                    }
                }

                return memo[0][s.Length - 1];
            }
        }
    }
}
