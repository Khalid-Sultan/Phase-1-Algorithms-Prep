using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Unique_Paths
    {
        public class Solution
        {
            public int UniquePaths(int m, int n)
            {
                int[][] dp_matrix = new int[m][];
                for (int i = 0; i < m; i++)
                {
                    dp_matrix[i] = new int[n];
                }
                for (int i = 0; i < m; i++)
                {
                    dp_matrix[i][0] = 1;
                }
                for (int i = 0; i < n; i++)
                {
                    dp_matrix[0][i] = 1;
                }
                for (int i = 1; i < m; i++)
                {
                    for (int j = 1; j < n; j++)
                    {
                        dp_matrix[i][j] = dp_matrix[i - 1][j] + dp_matrix[i][j - 1];
                    }
                }
                return dp_matrix[m - 1][n - 1];
            }
        }
    }
}
