using System;
using System.Collections.Generic;
using System.Text;

namespace Day_13
{
    class Beautiful_String
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> lines = new List<string>();
            for (int i = 0; i < n; i++)
            {
                lines.Add(Console.ReadLine());
            }
            foreach (string s in lines)
            {
                if (check(s) == false)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    Console.WriteLine(replace(s));
                }
            }
        }
        static bool check(string s)
        {
            char temp = s[0];
            if (s.Length == 1) return true;
            for (int i = 1; i < s.Length; i++)
            {
                if (temp == s[i] && s[i] != '?') return false;
                temp = s[i];
            }
            return true;
        }
        static string replace(string s)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '?')
                {
                    if (i < s.Length - 1 && s[i + 1] != '?')
                    {
                        if (builder.Length > 0)
                        {
                            if (builder[builder.Length - 1] == 'a')
                            {
                                if (s[i + 1] == 'a') builder.Append('b');
                                else if (s[i + 1] == 'b') builder.Append('c');
                                else if (s[i + 1] == 'c') builder.Append('b');
                            }
                            else if (builder[builder.Length - 1] == 'b')
                            {
                                if (s[i + 1] == 'a') builder.Append('c');
                                else if (s[i + 1] == 'b') builder.Append('c');
                                else if (s[i + 1] == 'c') builder.Append('a');
                            }
                            else if (builder[builder.Length - 1] == 'c')
                            {
                                if (s[i + 1] == 'a') builder.Append('b');
                                else if (s[i + 1] == 'b') builder.Append('a');
                                else if (s[i + 1] == 'c') builder.Append('b');
                            }
                        }
                        else
                        {
                            if (s[i + 1] == 'a') builder.Append('b');
                            else if (s[i + 1] == 'b') builder.Append('a');
                            else if (s[i + 1] == 'c') builder.Append('b');
                        }
                    }
                    else
                    {
                        if (builder.Length > 0)
                        {
                            if (builder[builder.Length - 1] == 'a') builder.Append('b');
                            else if (builder[builder.Length - 1] == 'b') builder.Append('a');
                            else if (builder[builder.Length - 1] == 'c') builder.Append('a');
                        }
                        else
                        {
                            builder.Append('a');
                        }
                    }
                }
                else
                {
                    builder.Append(s[i]);
                }
            }
            return builder.ToString();
        }
    }
}
