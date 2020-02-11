using System;
using System.Collections.Generic;
using System.Text;

namespace Day_33
{
    class Skylines
    {
        static int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int result = 0;

            int[] row_maxs = new int[grid.Length];
            int[] col_maxs = new int[grid.Length];

            for (int i = 0; i < grid.Length; i++)
            {
                int current_max = 0;
                col_maxs[i] = grid[0][i];
                for (int j = 0; j < grid[i].Length; j++)
                {
                    col_maxs[i] = Math.Max(col_maxs[i], grid[j][i]);
                    if (grid[i][j] > current_max)
                    {
                        current_max = grid[i][j];
                    }
                }
                row_maxs[i] = current_max;
            }

            for(int i = 0; i<grid.Length; i++)
            {
                int[] current_row = grid[i];
                for(int j = 0; j<current_row.Length; j++)
                {
                    if(current_row[j]<row_maxs[i] && row_maxs[i] <= col_maxs[j])
                    {
                        result += row_maxs[i] - current_row[j];
                    }
                    else if (current_row[j] < row_maxs[i] && row_maxs[i] > col_maxs[j])
                    {
                        result += col_maxs[j] - current_row[j];
                    }
                }
            }


            return result;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(MaxIncreaseKeepingSkyline(new int[][] {
        //        new int[] { 3, 0, 8, 4 },
        //        new int[] { 2, 4, 5, 7 },
        //        new int[] {9, 2, 6, 3 },
        //        new int[] { 0, 3, 1, 0 }
        //    }));
        //}

    }
}
