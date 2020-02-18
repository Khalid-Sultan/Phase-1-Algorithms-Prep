using System;
using System.Collections.Generic;
using System.Text;

namespace Day_35
{
    class Course_Schedule_II
    {
        static int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            int[] indegrees = new int[numCourses];

            int[] result_sequence = new int[numCourses];

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

            List<int> top_sort = new List<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (indegrees[i] == 0)
                {
                    queue.Enqueue(i);
                    //top_sort.Add(i);
                }
            }
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                if (result.Contains(current))
                {
                    return new int[] { };
                }
                result.Add(current);
                top_sort.Add(current);
                foreach (int i in pairs[current])
                {
                    indegrees[i]--;
                    if (indegrees[i] == 0)
                    {
                        queue.Enqueue(i);
                    }
                }
            }
            if (result.Count != numCourses)
            {
                return new int[] { };
            }

            for (int i = top_sort.Count - 1, j = 0; i >= 0; i--, j++)
            {
                result_sequence[j] = top_sort[i];
            }
            return result_sequence;
        }
        static void Main(string[] args)
        {
            int[] vs = FindOrder(4, new int[][] { new int[] { 1, 0 }, new int[] { 2, 0 }, new int[] { 3, 1 }, new int[] { 3, 2 } });
            foreach (int i in vs)
            {
                Console.WriteLine(i);
            }
        }
    }
}
