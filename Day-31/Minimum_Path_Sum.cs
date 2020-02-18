using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Minimum_Path_Sum
    {
        public class Solution
        {
            public int MinPathSum(int[][] grid)
            {
                if (grid == null)
                {
                    return 0;
                }
                int m = grid.Length;

                if (m == 0)
                {
                    return 0;
                }

                int n = grid[0].Length;
                int[][] dp_matrix = new int[m][];
                for (int i = 0; i < m; i++)
                {
                    dp_matrix[i] = new int[n];
                }

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dp_matrix[i][j] = 0;
                    }
                }

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dp_matrix[i][j] += grid[i][j];
                        if (i > 0 && j > 0)
                        {
                            dp_matrix[i][j] += Math.Min(dp_matrix[i - 1][j], dp_matrix[i][j - 1]);
                        }
                        else if (i > 0)
                        {
                            dp_matrix[i][j] += dp_matrix[i - 1][j];
                        }
                        else if (j > 0)
                        {
                            dp_matrix[i][j] += dp_matrix[i][j - 1];
                        }
                    }
                }
                return dp_matrix[m - 1][n - 1];
            }
        }
    }
}
