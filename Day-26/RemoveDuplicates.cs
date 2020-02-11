using System;
using System.Collections.Generic;
using System.Text;

namespace Day_26
{
    class RemoveDuplicates
    {
        static int i { get; set; } = 0;
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(RemoveDuplicateLetters("cbacdcbc"));
        //}

        static string RemoveDuplicateLetters(string s)
        {
            Dictionary<char, int> pairs = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (pairs.ContainsKey(c))
                {
                    pairs[c]++;
                }
                else
                {
                    pairs.Add(c, 1);
                }
            }

            Stack<char> characters = new Stack<char>();
            characters.Push(s[0]);
            for (int i = 1; i<s.Length; i++)
            {
                char c = s[i];
                if (characters.Count > 0 && characters.Peek() < c)
                {
                    characters.Push(c);
                    pairs[c]--;
                    continue;
                }
                else
                {
                    while (characters.Count > 0 && characters.Peek() > c)
                    {
                        if (pairs[characters.Peek()] > 1)
                        {
                            char c_temp = characters.Pop();
                            pairs[c_temp]--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            List<char> chars = new List<char>();
            while (characters.Count > 0)
            {
                chars.Add(characters.Pop());
            }
            chars.Reverse();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in chars)
            {
                stringBuilder.Append(c);
            }


            foreach(char key in pairs.Keys)
            {
                if (pairs[key] == 1)
                {
                    stringBuilder.Append(key);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
