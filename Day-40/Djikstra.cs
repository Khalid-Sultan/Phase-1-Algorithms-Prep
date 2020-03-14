using System;
using System.Collections.Generic;
using System.Text;

namespace Day_40
{
    class Djikstra
    {
        public static long result = 0;
        static long Djikstra_CodeForces()
        {

            string[] row_input = Console.ReadLine().Split(' ');
            int row = Convert.ToInt32(row_input[0]);
            int col = Convert.ToInt32(row_input[1]);

            string[] start_input = Console.ReadLine().Split(' ');
            int start_row = Convert.ToInt32(start_input[0]) - 1;
            int start_col = Convert.ToInt32(start_input[1]) - 1;

            string[] limit_input = Console.ReadLine().Split(' ');
            int left_limit = Convert.ToInt32(limit_input[0]);
            int right_limit = Convert.ToInt32(limit_input[1]);

            int[][] grid = new int[row][];
            for (int i = 0; i < row; i++)
            {
                grid[i] = new int[col];
                char[] row_filler = Console.ReadLine().ToCharArray();
                for (int j = 0; j < col; j++)
                {
                    if (row_filler[j] == '.')
                    {
                        grid[i][j] = 0;
                    }
                    else
                    {
                        grid[i][j] = 1;
                    }
                }
            }

            DFS(grid, start_row, start_col, left_limit, right_limit);
            return result;
        }

        static void DFS(int[][] grid, int row, int col, int left_limit, int right_limit)
        {
            if (row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length || left_limit < 0 || right_limit < 0)
            {
                return;
            }
            if (grid[row][col] == 0)
            {
                result++;
                grid[row][col] = 1;
                DFS(grid, row - 1, col, left_limit, right_limit);
                DFS(grid, row + 1, col, left_limit, right_limit);
                DFS(grid, row, col - 1, left_limit - 1, right_limit);
                DFS(grid, row, col + 1, left_limit, right_limit - 1);
            }
        }


        //public static void Main(String[] args)
        //{
        //    Console.WriteLine(Djikstra_CodeForces());
        //}
    }
}
