using System;
using System.Collections.Generic;
using System.Text;

namespace Day_40
{
    class Labyrinth
    {
        static long Labyrinth_CodeForces()
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

            long result = DFS(grid, start_row, start_col, left_limit, right_limit);
            return result;
        }

        static long DFS(int[][] grid, int row, int col, int left_limit, int right_limit)
        {
            long result = 0;
            List<Tuple<Tuple<int, int>, Tuple<int, int>>> stack = new List<Tuple<Tuple<int, int>, Tuple<int, int>>>();
            HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();

            Tuple<int, int> initial = Tuple.Create(row, col);
            Tuple<int, int> limits = Tuple.Create(left_limit, right_limit);
            stack.Add(Tuple.Create(initial, limits));

            while (stack.Count > 0)
            {
                Tuple<Tuple<int, int>, Tuple<int, int>> temp = stack[0];
                stack.RemoveAt(0);
                Tuple<int, int> coordinates = temp.Item1;
                limits = temp.Item2;
                visited.Add(coordinates);
                if (grid[coordinates.Item1][coordinates.Item2] == 0)
                {
                    if (!visited.Contains(Tuple.Create(coordinates.Item1 - 1, coordinates.Item2)) && coordinates.Item1 - 1 >= 0 && grid[coordinates.Item1 - 1][coordinates.Item2] == 0)
                    {
                        stack.Insert(0, Tuple.Create(Tuple.Create(coordinates.Item1 - 1, coordinates.Item2), Tuple.Create(limits.Item1, limits.Item2)));
                    }
                    if (!visited.Contains(Tuple.Create(coordinates.Item1 + 1, coordinates.Item2)) && coordinates.Item1 + 1 < grid.Length && grid[coordinates.Item1 + 1][coordinates.Item2] == 0)
                    {
                        stack.Insert(0, Tuple.Create(Tuple.Create(coordinates.Item1 + 1, coordinates.Item2), Tuple.Create(limits.Item1, limits.Item2)));
                    }
                    if (!visited.Contains(Tuple.Create(coordinates.Item1, coordinates.Item2 - 1)) && limits.Item1 > 0 && coordinates.Item2 - 1 >= 0 && grid[coordinates.Item1][coordinates.Item2 - 1] == 0)
                    {
                        stack.Add(Tuple.Create(Tuple.Create(coordinates.Item1, coordinates.Item2 - 1), Tuple.Create(limits.Item1 - 1, limits.Item2)));
                    }
                    if (!visited.Contains(Tuple.Create(coordinates.Item1, coordinates.Item2 + 1)) && limits.Item2 > 0 && coordinates.Item2 + 1 < grid[0].Length && grid[coordinates.Item1][coordinates.Item2 + 1] == 0)
                    {
                        stack.Add(Tuple.Create(Tuple.Create(coordinates.Item1, coordinates.Item2 + 1), Tuple.Create(limits.Item1, limits.Item2 - 1)));
                    }
                    result++;
                }
            }
            return result;
        }


        public static void Main(String[] args)
        {
            Console.WriteLine(Labyrinth_CodeForces());
        }
    }
}