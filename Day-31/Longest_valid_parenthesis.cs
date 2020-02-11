using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Longest_valid_parenthesis
    {
        static int LongestValidParentheses(string s)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);
            int max = 0;
            for(int i = 0; i<s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        stack.Push(i);
                    }
                    else
                    {
                        max = Math.Max(max, i - stack.Peek());
                    }
                }
            }
            return max;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(LongestValidParentheses("()(()"));
        //    Console.WriteLine(LongestValidParentheses(")()())"));
        //    Console.WriteLine(LongestValidParentheses("(()"));
        //    Console.WriteLine(LongestValidParentheses(")()())()()()()))))()("));
        //}

    }
}
