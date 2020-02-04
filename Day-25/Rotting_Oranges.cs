using System;
using System.Collections.Generic;
using System.Text;

namespace Day_25
{
    class Rotting_Oranges
    {
        static int OrangesRotting(int[][] grid)
        {
            int moves = 0;
            int result = 0;

            while (true)
            {
                for(int i = 0; i < grid.Length; i++)
                {
                    for(int j = 0; j<grid[i].Length; j++)
                    {
                        int currentElement = grid[i][j];
                        if (currentElement == 0)
                        {
                            continue;
                        }
                        if (currentElement == 1)
                        {
                            continue;
                        }
                        if (currentElement == 2)
                        {
                            if(i+1 < grid.Length && grid[i+1][j]==1)
                            {
                                grid[i+1][j] = 2;
                                moves++;
                            }
                            if(j+1 < grid[i].Length && grid[i][j+1] == 1)
                            {
                                grid[i][j + 1] = 2;
                                moves++;
                            }
                        }
                    }
                }
                result++;
                if (moves == 0)
                {
                    moves = 0;
                    break;
                }
            }
            return result;
        }
        static void Main(String[] args)
        {
            Console.WriteLine(OrangesRotting(new int[][]{ new int[]{ 2, 1, 1 }, new int[]{1, 1, 0},new int[]{0, 1, 1} }));
        }


    }
}
