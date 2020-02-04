using System;
using System.Collections.Generic;
using System.Text;

namespace Day_26
{
    class AddValidParenthesis
    {
        public int MinAddToMakeValid(string S)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char key in S)
            {
                if (key == '(')
                {
                    stack.Push(key);
                }
                else
                {
                    if (stack.Count > 0 && (stack.Peek() == '(' && key == ')'))
                        stack.Pop();
                    else
                        stack.Push(key);
                }
            }
            return stack.Count;
        }
    }
}
