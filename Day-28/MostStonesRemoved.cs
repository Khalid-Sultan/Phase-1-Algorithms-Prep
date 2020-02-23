using System;
using System.Collections.Generic;
using System.Text;

namespace Day_28
{
    class MostStonesRemoved
    {
        public static int Rows;
        public static bool[][] graph = new bool[1005][];
        public static bool[] visited = new bool[1005];
        public int RemoveStones(int[][] stones)
        {
            Rows = stones.Length;
            for (int row = 0; row < 1005; row++)
            {
                graph[row] = new bool[1005];
            }

            for (int row = 0; row < 1005; row++)
            {
                visited[row] = false;
            }

            for (int row = 0; row < Rows; row++)
            {
                for (int j = row + 1; j < Rows; j++)
                {
                    if (stones[row][0] == stones[j][0] ||
                        stones[row][1] == stones[j][1])
                    {
                        graph[row][j] = true;
                        graph[j][row] = true;
                    }
                }
            }

            int result = 0;
            for (int row = 0; row < Rows; row++)
            {
                if (visited[row])
                {
                    continue;
                }

                result++;

                dfs(row);
            }

            return Rows - result;
        }

        private static void dfs(int id)
        {
            if (visited[id])
            {
                return;
            }

            visited[id] = true;

            for (int row = 0; row < Rows; row++)
            {
                if (graph[id][row])
                {
                    dfs(row);
                }
            }
        }
    }
}
