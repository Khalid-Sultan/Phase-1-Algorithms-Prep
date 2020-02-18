using System;
using System.Collections.Generic;
using System.Text;

namespace Day_36
{
    class Loud_And_Rich
    {
        static int[] LoudAndRich(int[][] richer, int[] quiet)
        {
            Dictionary<int, HashSet<int>> richer_pairs = new Dictionary<int, HashSet<int>>();
            foreach (int[] rich in richer)
            {
                if (richer_pairs.ContainsKey(rich[1]))
                {
                    richer_pairs[rich[1]].Add(rich[0]);
                }
                else
                {
                    HashSet<int> temp = new HashSet<int>();
                    temp.Add(rich[0]);
                    richer_pairs.Add(rich[1], temp);
                }
            }
            int[] answer = new int[quiet.Length];
            for (int i = 0; i < quiet.Length; i++)
            {
                answer[i] = 0;
            }

            for (int i = 0; i < quiet.Length; i++)
            {
                if (!richer_pairs.ContainsKey(i))
                {
                    answer[i] = i;
                    continue;
                }
                int[] visited = new int[quiet.Length];
                for(int k= 0; k<visited.Length; k++)
                {
                    visited[k] = -1;
                }
                answer[i] = FindRicherPairs(i, richer_pairs, quiet, i, visited);
            }
            return answer;
        }
        static int FindRicherPairs(int i, Dictionary<int, HashSet<int>> keyValuePairs, int[] quiet, int quietest, int[] visited)
        {
            if (visited[i]!= -1)
            {
                return quietest;
            }

            visited[i] = 0;
            if (keyValuePairs.ContainsKey(i))
            {
                foreach (int el in keyValuePairs[i])
                {
                    if(quiet[el] < quiet[quietest])
                    {
                        quietest = el;
                    }
                    quietest = FindRicherPairs(el, keyValuePairs, quiet, quietest, visited);
                }
            }
            return quietest;
        }
        //static void Main(String[] args)
        //{
        //    int[] answer = LoudAndRich(new int[][] {
        //        new int[] { 1, 0 },
        //        new int[] { 2, 1 },
        //        new int[] { 3, 1 },
        //        new int[] { 3, 7 },
        //        new int[] { 4, 3 },
        //        new int[] { 5, 3 },
        //        new int[] { 6, 3 }
        //    },
        //    new int[] { 3, 2, 5, 4, 6, 1, 7, 0 });
        //    foreach(int el in answer)
        //    {
        //        Console.WriteLine(el);
        //    }
        //}
    }
}
