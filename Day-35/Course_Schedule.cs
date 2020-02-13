using System;
using System.Collections.Generic;
using System.Text;

namespace Day_35
{
    class Course_Schedule
    {
        static bool CanFinish(int numCourses, int[][] prerequisites)
        {
                int[] indegrees = new int[numCourses];
                Dictionary<int, List<int>> pairs = new Dictionary<int, List<int>>();
                for (int i = 0; i < numCourses; i++)
                {
                    indegrees[i] = 0;
                    pairs[i] = new List<int>();
                }
                HashSet<int> result = new HashSet<int>();

                foreach (int[] paths in prerequisites)
                {
                    indegrees[paths[1]]++;
                    pairs[paths[0]].Add(paths[1]);
                }

                Queue<int> queue = new Queue<int>();
                for (int i = 0; i < numCourses; i++)
                {
                    if (indegrees[i] == 0)
                    {
                        queue.Enqueue(i);
                    }
                }
                while (queue.Count > 0)
                {
                    int current = queue.Dequeue();
                    if (result.Contains(current))
                    {
                        return false;
                    }
                    result.Add(current);
                    foreach (int i in pairs[current])
                    {
                        indegrees[i]--;
                        if (indegrees[i] == 0)
                        {
                            queue.Enqueue(i);
                        }
                    }
                }
                return result.Count == numCourses;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CanFinish(2, new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } }));
        }
    }
}