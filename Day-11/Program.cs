using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_11
{
    public class Solution
    {
        public static void Main(String[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            List<string> lines = new List<string>();
            //for (int i = 0; i < n; i++)
            //{
            //    lines.Add(Console.ReadLine());
            //}
            lines.Add("a???cb");
            lines.Add("a??bbc");
            lines.Add("a?b?c");

            List<string> results = new List<string>();
            foreach(string c in lines)
            {
                char[] c_arr = c.ToCharArray();
                int duplicate = 0;
                for (int j = 0; j<c_arr.Length; j++)
                {
                    char curr_char = c_arr[j];
                    char prev_char = ' ';
                    char next_char = ' ';
                    if (curr_char == '?')
                    {
                        if (j > 0)
                        {
                            prev_char = c_arr[j - 1];

                        }
                        if (j < c_arr.Length)
                            next_char = c_arr[j + 1];

                        //When Both Prev and Next exist
                        if (prev_char != ' ' && prev_char == 'a' && next_char != ' ' && next_char != 'b')
                        {
                            c_arr[j] = 'b';
                        }
                        else if (prev_char != ' ' && prev_char == 'a' && next_char != ' ' && next_char != 'c')
                        {
                            c_arr[j] = 'c';
                        }
                        else if (prev_char != ' ' && prev_char == 'b' && next_char != ' ' && next_char != 'a')
                        {
                            c_arr[j] = 'a';
                        }
                        else if (prev_char != ' ' && prev_char == 'b' && next_char != ' ' && next_char != 'c')
                        {
                            c_arr[j] = 'c';
                        }
                        else if (prev_char != ' ' && prev_char == 'c' && next_char != ' ' && next_char != 'a')
                        {
                            c_arr[j] = 'a';
                        }
                        else if (prev_char != ' ' && prev_char == 'c' && next_char != ' ' && next_char != 'b')
                        {
                            c_arr[j] = 'b';
                        }


                        //When Only Next exist
                        if (prev_char == ' ' && next_char != ' ' && next_char != 'b')
                        {
                            c_arr[j] = 'b';
                        }
                        else if (prev_char == ' ' && next_char != ' ' && next_char != 'c')
                        {
                            c_arr[j] = 'c';
                        }
                        else if (prev_char == ' ' && next_char != ' ' && next_char != 'a')
                        {
                            c_arr[j] = 'a';
                        } 

                        //When Only Prev exist
                        if (next_char == ' ' && prev_char != ' ' && prev_char != 'c')
                        {
                            c_arr[j] = 'c';
                        }
                        else if (next_char == ' ' && prev_char != ' ' && prev_char != 'a')
                        {
                            c_arr[j] = 'a';
                        }
                        else if (next_char == ' ' && prev_char != ' ' && prev_char != 'b')
                        {
                            c_arr[j] = 'b';
                        }

                    }

                }
                char last_one = c_arr[0];
                for (int i = 1; i < c_arr.Length; i++)
                {
                    if (c_arr[i] == last_one)
                    {
                        duplicate = -1;
                        break;
                    }
                    last_one = c_arr[i];
                }
                if (duplicate == -1) results.Add("-1");
                else results.Add(new string(c_arr));
            }

            foreach (string c in results)
            {
                Console.WriteLine(c);
            }
        }
    }
}
