using System;
using System.Collections.Generic;
using System.Text;

namespace Day_25
{
    class Friend_Circles
    {
        static int FindCircleNum(int[][] M)
        {
            Dictionary<int, List<int>> friends = new Dictionary<int, List<int>>();
            for (int i = 0; i<M.Length; i++)
            {
                List<int> friendsList = new List<int>();
                for (int j = 0; j<M.Length; j++)
                {
                    if (M[i][j] == 1)
                    {
                        friendsList.Add(j);
                    }
                }
                friends.Add(i, friendsList);
            }

            HashSet<int> visited = new HashSet<int>();

            int count = 0;
            for (int i = 0; i < M.Length; i++)
            {
                if (!visited.Contains(i))
                {
                    count++;
                    traverse(i, friends, visited);
                }
            }
            return count;
        }

        static void traverse(int i, Dictionary<int, List<int>> friends, HashSet<int> visited)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(i);

            while (stack.Count > 0)
            {
                int current = stack.Pop();
                visited.Add(current);

                if (friends.ContainsKey(current))
                {
                    List<int> friendsList = friends[current];

                    foreach(int j in friendsList)
                    {
                        if (!visited.Contains(j))
                        {
                            visited.Add(j);
                            stack.Push(j);
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindCircleNum(new int[][] {
                new int[]{ 1, 1, 0},
                new int[]{ 1, 1, 1},
                new int[]{ 0, 1, 1},
            }));


            //[[1,0,0,1],[0,1,1,0],[0,1,1,1],[1,0,1,1]]
        }
    }
}
