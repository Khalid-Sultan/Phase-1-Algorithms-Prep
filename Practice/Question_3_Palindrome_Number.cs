using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Question_3_Palindrome_Number
    {
        /*
        Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
        Example 1:
            Input: 121
            Output: True
        Example 2:
            Input: -121
            Output: False
        Example 3:
            Input: 10
            Output: False
        Follow Up: Could you solve it without converting the integer to a string
        */
        static int ReverseInteger(int num)
        {
            long result = 0;
            while (num != 0)
            {
                result = (result * 10) + num % 10;
                num /= 10;
            }
            if (result > int.MaxValue)
            {
                return 0;
            }
            else if (result < int.MinValue)
            {
                return 0;
            }
            return Convert.ToInt32(result);
        }

        static bool IsPalindrome(int num)
        {
            if (num < 0)
            {
                return false;
            }
            if (ReverseInteger(num) == num)
            {
                return true;
            }
            return false;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(IsPalindrome(121));
        //    Console.WriteLine(IsPalindrome(-121));
        //    Console.WriteLine(IsPalindrome(10));
        //}
    }
}
