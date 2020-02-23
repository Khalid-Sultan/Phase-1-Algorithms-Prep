using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_34
{
    class Unique_Paths_III
    {
        public int final_counter = 0;
        public int UniquePathsIII(int[][] grid)
        {
            //Count Zeros to count the possible untracked locations, also track starting and ending point
            int zeros_counter = 0;
            int[] starting_point = new int[] { 0, 0 };
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        zeros_counter++;
                    }
                    if (grid[i][j] == 1)
                    {
                        starting_point[0] = i;
                        starting_point[1] = j;
                    }
                }
            }
            
            dfs(starting_point[0], starting_point[1], grid, zeros_counter);
            return final_counter;
        }

        public void dfs(int row, int col, int[][] grid, int zeros_counter)
        {
            if (col >= grid[0].Length || row >= grid.Length || col < 0 || row < 0 || grid[row][col] < 0)
            {
                return;
            }

            if (grid[row][col] == 2)
            {
                if (zeros_counter == 0)
                {
                    this.final_counter++;
                    return;
                }
            }

            grid[row][col] = -2;

            //Move Left
            dfs(row, col + 1, grid, zeros_counter - 1);
            //Move Right
            dfs(row, col - 1, grid, zeros_counter - 1);
            //Move Down
            dfs(row + 1, col, grid, zeros_counter - 1);
            //Move Up
            dfs(row - 1, col, grid, zeros_counter - 1);

            grid[row][col] = 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }

    }
}
