using System;
using System.Collections.Generic;
using System.Text;

namespace Day_40
{
    class Find_Minimum_City
    {
        public int FindTheCity(int n, int[][] edges, int distanceThreshold)
        {
            var graph = new Dictionary<int, Dictionary<int, int>>();
            for (int i = 0; i < n; i++)
                graph[i] = new Dictionary<int, int>();

            foreach (var edge in edges)
            {
                int u = edge[0], v = edge[1], w = edge[2];
                graph[u][v] = w;
                graph[v][u] = w;
            }

            int min_distance = n + 1;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int count = check(graph, distanceThreshold, i);
                if (count <= min_distance)
                {
                    min_distance = count;
                    result = i;
                }
            }

            return result;
        }

        private int check(Dictionary<int, Dictionary<int, int>> graph, int distanceThreshold, int node)
        {
            Dictionary<int, int> visited = new Dictionary<int, int>();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node);

            visited[node] = 0;
            while (queue.Count != 0)
            {

                int curr = queue.Dequeue(), currDist = visited[curr];
                foreach (var edges in graph[curr])
                {
                    int neighbor = edges.Key, dist = edges.Value;
                    if (currDist + dist <= distanceThreshold)
                    {
                        if (!visited.ContainsKey(neighbor))
                        {
                            visited[neighbor] = currDist + dist;
                            queue.Enqueue(neighbor);
                        }
                        else if (visited[neighbor] > currDist + dist)
                        {
                            visited[neighbor] = currDist + dist;
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }

            return visited.Count;
        }
    }
}
