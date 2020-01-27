using System;
using System.Collections.Generic;
using System.Text;

namespace Day_26
{
    class Is_Subsequence
    {
        static bool IsSubsequence(string s, string t)
        {
            Dictionary<char, List<int>> keyValuePairs = new Dictionary<char, List<int>>();
            for(int i = 0; i<t.Length; i++)
            {
                if (keyValuePairs.ContainsKey(t[i]))
                {
                    keyValuePairs[t[i]].Add(i);
                }
                else
                {
                    keyValuePairs.Add(t[i], new List<int>() { i });
                }
            }

            int previous = -1;
            foreach(char c in s){
                if (keyValuePairs.ContainsKey(c))
                {
                    if (keyValuePairs[c].Count>0 && keyValuePairs[c][0] > previous)
                    {
                        previous = keyValuePairs[c][0];
                        keyValuePairs[c].RemoveAt(0);
                        continue;
                    }
                    return false;            
                }
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsSubsequence("axc", "ahbgdc"));
        }
    }
}
