using System;
using System.Collections.Generic;
using System.Text;

namespace Day_24
{
    class Find_Common_Characters
    {
        public static IList<string> CommonChars(string[] A)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            List<string> ls = new List<string>();

            foreach (char c in A[0].ToCharArray())
            {
                if (keyValuePairs.ContainsKey(c)) keyValuePairs[c]++;
                else keyValuePairs.Add(c, 1);
            }
            if (A.Length == 1)
            {
                foreach (char s in keyValuePairs.Keys) ls.Add($"{s}");
                return ls;
            }

            for (int i = 1; i < A.Length; i++)
            {
                Dictionary<char, int> temp = new Dictionary<char, int>();
                foreach (char c in A[i].ToCharArray())
                {
                    if (temp.ContainsKey(c)) temp[c]++;
                    else temp.Add(c, 1);
                }

                List<char> keys = new List<char>(keyValuePairs.Keys);
                foreach (char c in keys)
                {
                    if (temp.ContainsKey(c) && keyValuePairs[c] == temp[c]) continue;
                    else if (temp.ContainsKey(c) && keyValuePairs[c] != temp[c]) keyValuePairs[c] = Math.Min(keyValuePairs[c], temp[c]);
                    else keyValuePairs.Remove(c);
                }
            }
            foreach (char s in keyValuePairs.Keys) for (int i = 0; i < keyValuePairs[s]; i++) ls.Add($"{s}");
            return ls;

        }

    }
}
