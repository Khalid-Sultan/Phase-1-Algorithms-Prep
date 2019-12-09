using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    List<string> lines = new List<string>();
        //    for (int i = 0; i < n; i++)
        //    {
        //        lines.Add(Console.ReadLine());
        //    }
        //    foreach (string line in lines)
        //    {
        //        bool doubles = check(line);
        //        if (doubles == false)
        //        {
        //            Console.WriteLine("-1");
        //            continue;
        //        }
        //        string test = replaced(line,0);
        //        if (test == "-1")
        //        {
        //            test = replaced(line, 1);
        //            if(test=="-1")
        //            Console.WriteLine("-1");
        //            continue;
        //        }
        //        Console.WriteLine(test);
        //    }
        //}
        static bool check(string line)
        {
            char first_character = line[0];
            for (int i = 1; i < line.Length; i++)
            {
                char second_character = line[i];
                if (first_character == second_character && first_character != '?' && second_character != '?') return false;
                else
                {
                    first_character = second_character;
                }
            }
            return true;
        }
        static string replaced(string line, int test)
        {
            StringBuilder stringBuilder = new StringBuilder();
            char[] charArray = line.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if(i==0 && line.Length == 1)
                {
                    return "a";
                }
                else if (i == 0)
                {
                    if (charArray[i + 1] == 'a') charArray[i] = 'c';
                    else if (charArray[i + 1] == 'b') charArray[i] = 'a';
                    else if (charArray[i + 1] == 'c') charArray[i] = 'b';
                    else charArray[i] = 'a';
                }
                if (charArray[i] == '?')
                {
                    if (i == line.Length - 1)
                    {
                        if (charArray[i-1] == 'a') charArray[i] = 'c';
                        else if (charArray[i - 1] == 'b') charArray[i] = 'a';
                        else if (charArray[i - 1] == 'c') charArray[i] = 'b';
                    }
                    else
                    {
                        if (test == 0)
                        {
                            if ((charArray[i - 1] == 'a' && charArray[i + 1] == 'b') || (charArray[i - 1] == 'b' && charArray[i + 1] == 'a')) charArray[i] = 'c';
                            else if ((charArray[i - 1] == 'a' && charArray[i + 1] == 'c') || (charArray[i - 1] == 'c' && charArray[i + 1] == 'a')) charArray[i] = 'b';
                            else if ((charArray[i - 1] == 'c' && charArray[i + 1] == 'b') || (charArray[i - 1] == 'b' && charArray[i + 1] == 'c')) charArray[i] = 'a';
                            else 
                            {
                                if (charArray[i - 1] == 'a') charArray[i] = 'c';
                                else if (charArray[i - 1] == 'b') charArray[i] = 'a';
                                else if (charArray[i - 1] == 'c') charArray[i] = 'b';
                            }
                            //else return "-1";
                        }
                        else
                        {
                            if ((charArray[i - 1] == 'a' && charArray[i + 1] == 'b') || (charArray[i - 1] == 'b' && charArray[i + 1] == 'a')) charArray[i] = 'c';
                            else if ((charArray[i - 1] == 'a' && charArray[i + 1] == 'c') || (charArray[i - 1] == 'c' && charArray[i + 1] == 'a')) charArray[i] = 'b';
                            else if ((charArray[i - 1] == 'c' && charArray[i + 1] == 'b') || (charArray[i - 1] == 'b' && charArray[i + 1] == 'c')) charArray[i] = 'a';
                            else 
                            {
                                if (charArray[i - 1] == 'a') charArray[i] = 'b';
                                else if (charArray[i - 1] == 'b') charArray[i] = 'c';
                                else if (charArray[i - 1] == 'c') charArray[i] = 'a';
                            }
                            //else return "-1";
                        }
                    }
                }
                stringBuilder.Append(charArray[i]);
            }
            string result = stringBuilder.ToString();
            return result;
        }
    }
}

