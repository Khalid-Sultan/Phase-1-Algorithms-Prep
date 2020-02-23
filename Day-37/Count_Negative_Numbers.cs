using System;
using System.Collections.Generic;
using System.Text;

namespace Day_37
{
    class Count_Negative_Numbers
    {
        public int CountNegatives(int[][] grid)
        {
            int result = 0;
            for (int i = grid.Length - 1; i >= 0; i--)
            {
                for (int j = grid[i].Length - 1; j >= 0; j--)
                {
                    if (grid[i][j] >= 0)
                    {
                        break;
                    }
                    result++;
                }
            }
            return result;
        }

    }
}
