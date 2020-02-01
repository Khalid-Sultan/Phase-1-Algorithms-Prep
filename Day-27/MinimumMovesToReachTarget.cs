using System;
using System.Collections.Generic;
using System.Text;

namespace Day_27
{
    class MinimumMovesToReachTarget
    {
        public static int MinimumMoves(int[][] grid)
        {
            Queue<int> q = new Queue<int>();
            Queue<bool> pos = new Queue<bool>();

            HashSet<int> v = new HashSet<int>();
            HashSet<int> h = new HashSet<int>();

            int n = grid.Length;
            int start = n * 0 + 1;

            // horizontal = true / vertical = false
            q.Enqueue(start);
            pos.Enqueue(true);

            int[] rows = new int[4] { 0, -1, 0, 1 };
            int[] cols = new int[4] { -1, 0, 1, 0 };

            int move = 0;
            while (q.Count > 0)
            {
                int count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    int num = q.Dequeue();
                    bool d = pos.Dequeue();
                    int r = num / n;
                    int c = num % n;

                    if (r == n - 1 && c == n - 1 && d == true)
                    {
                        return move;
                    }

                    if (d == true) // horizontal
                    {
                        if (c < n - 1 && grid[r][c + 1] == 0 && !h.Contains(r * n + c + 1))
                        {
                            q.Enqueue(r * n + c + 1);
                            pos.Enqueue(true);
                            h.Add(r * n + c + 1);
                        }

                        if (r < n - 1 && grid[r + 1][c] == 0 && grid[r + 1][c - 1] == 0 && !h.Contains((r + 1) * n + c))
                        {
                            q.Enqueue((r + 1) * n + c);
                            pos.Enqueue(true);
                            h.Add((r + 1) * n + c);
                        }

                        if (r < n - 1 && grid[r + 1][c] == 0 && grid[r + 1][c - 1] == 0 && !v.Contains((r + 1) * n + c - 1))
                        {
                            q.Enqueue((r + 1) * n + c - 1);
                            pos.Enqueue(false);
                            v.Add((r + 1) * n + c - 1);
                        }
                    }
                    else
                    {
                        if (c < n - 1 && grid[r - 1][c + 1] == 0 && grid[r][c + 1] == 0 && !v.Contains(r * n + c + 1))
                        {
                            q.Enqueue(r * n + c + 1);
                            pos.Enqueue(false);
                            v.Add(r * n + c + 1);
                        }

                        if (r < n - 1 && grid[r + 1][c] == 0 && !v.Contains((r + 1) * n + c))
                        {
                            q.Enqueue((r + 1) * n + c);
                            pos.Enqueue(false);
                            v.Add((r + 1) * n + c);
                        }

                        if (c < n - 1 && grid[r - 1][c + 1] == 0 && grid[r][c + 1] == 0 && !h.Contains((r - 1) * n + c + 1))
                        {
                            q.Enqueue((r - 1) * n + c + 1);
                            pos.Enqueue(true);
                            h.Add((r - 1) * n + c + 1);
                        }
                    }
                }

                move++;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumMoves(
                new int[][]
                {
                    new int[]{ 0, 0, 0, 0, 0, 1 },
                    new int[]{ 1, 1, 0, 0, 1, 0 },
                    new int[]{ 0, 0, 0, 0, 1, 1 },
                    new int[]{ 0, 0, 1, 0, 1, 0 },
                    new int[]{ 0, 1, 1, 0, 0, 0 },
                    new int[]{ 0, 1, 1, 0, 0, 0 }
                }
                ));

        }

    }
}
