using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Question_2_Reverse_Integer
    {
        /*
            Given a 32 bit signed integer, reverse the digits of an integer.
            Example 1: 
                Input: 123
                Output: 321
            Example 2: 
                Input: -123
                Output: -321
            Example 1: 
                Input: 120
                Output: 21
            Note:
            Assume we are dealing with an environment which could only store integers
            within the 32-bit signed integer range: [-231, 231-1]. For the purpose of 
            this problem, assume that your function returns 0 when the reversed integer overflows.
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
        
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(ReverseInteger(123));
        //    Console.WriteLine(ReverseInteger(-123));
        //    Console.WriteLine(ReverseInteger(120));
        //}
    }
}
