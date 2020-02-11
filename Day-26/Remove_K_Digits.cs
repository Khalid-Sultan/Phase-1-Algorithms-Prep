using System;
using System.Collections.Generic;
using System.Text;

namespace Day_26
{
    class Remove_K_Digits
    {
        static string cleanNumber(string num)
        {
            if (num.StartsWith("0"))
            {
                while (num.StartsWith("0"))
                {
                    num = num.Remove(0, 1);
                }
            }
            return num;
        }
        static string RemoveKdigits(string num, int k, int counter)
        {
            num = cleanNumber(num);
            if (num == "" || k >= num.Length)
            {
                return "0";
            }
            if (k == 0)
            {
                return num;
            }

            int prev = 0;
            while(k>0)
            {
                num = cleanNumber(num);
                if (prev<num.Length-1 && num[prev] > num[prev+1])
                {
                    num = num.Remove(prev, 1);
                    k--;
                    continue;
                }
                else if (prev < num.Length - 1 && num[prev] == num[prev+1])
                {
                    num = num.Remove(prev, 1);
                    k--;
                    continue;
                }
                else
                {
                    int temp = prev + 1;
                    while (num[temp] > num[temp - 1])
                    {
                        temp++;
                    }
                    num = num.Remove(temp-1, 1);
                    k--;
                    continue;
                }
            }
            return RemoveKdigits(num, k,0);
        }
        static string RemoveKdigits(string num, int k)
        {
            return RemoveKdigits(num, k, 0);
        }

        static void Main(String[] args)
        {
            Console.WriteLine(RemoveKdigits("1432219", 3));
            Console.WriteLine(RemoveKdigits("10200", 1));
            Console.WriteLine(RemoveKdigits("10200", 2));
            Console.WriteLine(RemoveKdigits("15180", 2));
            Console.WriteLine(RemoveKdigits("10", 2));
            Console.WriteLine(RemoveKdigits("43214321", 4));
            Console.WriteLine(RemoveKdigits("112", 1));
        }

    }
}
