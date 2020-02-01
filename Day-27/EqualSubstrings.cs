using System;
using System.Collections.Generic;
using System.Text;

namespace Day_27
{
    class EqualSubstrings
    {
        public static int EqualSubstring(string s, string t, int maxCost)
        {
            List<int> values = new List<int>();
            for (int i = 1; i <= s.Length; i++)
            {
                values.Add(Math.Abs(t[i - 1] - s[i - 1]));
            }

            int p = 0;
            int e = 0;
            int max = 0;
            int min = values[0];

            while (p < s.Length && e < t.Length)
            {
                if (min <= maxCost)
                {
                    max = Math.Max(max, e - p + 1);
                    e++;
                    if (p < s.Length && e < t.Length)
                    {
                        min += values[e];
                    }
                }
                else
                {
                    min -= values[p];
                    p++;
                    if (p > e)
                    {
                        max = Math.Max(max, e - p + 1);
                        e++;
                        if (p < s.Length && e < t.Length)
                        {
                            min += values[e];
                        }
                    }
                }
            }
            return max;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(EqualSubstring("abcd", "bcdf", 3));
        //    Console.WriteLine(EqualSubstring("abcd", "cdef", 3));
        //    Console.WriteLine(EqualSubstring("abcd", "cdef", 1));
        //    Console.WriteLine(EqualSubstring("abcd", "acde", 0));

        //    Console.WriteLine(EqualSubstring("abcd", "abcd", 0));
        //    Console.WriteLine(EqualSubstring("abcd", "ddff", 1));
        //    Console.WriteLine(EqualSubstring("krrgw", "zjxss", 19));
        //    Console.WriteLine(EqualSubstring("pxezla", "loewbi", 25));

        //}
    }
}
