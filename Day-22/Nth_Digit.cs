using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class Nth_Digit
    {
        public static int FindNthDigit(int n)
        {
            if (n <= 9) return n;

            int result = 0;
            int i = 1;
            int counter = 1;

            while(i < n)
            {
                char[] s = $"{counter}".ToCharArray();
                if (s.Length <= n - i)
                {
                    i += s.Length;
                }
                else
                {
                    result = s[n-i];
                    break;
                }
            }
            return result;            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindNthDigit(3));
            Console.WriteLine(FindNthDigit(11));
            Console.WriteLine(FindNthDigit(120));
        }
    }
}
