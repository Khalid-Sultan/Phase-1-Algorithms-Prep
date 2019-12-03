using System;
using System.Collections.Generic;
using System.Text;

namespace Day_8
{
    class Valid_Parenthesis
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char key in s)
            {
                if (key == '(' || key == '[' || key == '{')
                {
                    stack.Push(key);
                }
                else
                {
                    if (stack.Count < 1) return false;
                    if ((stack.Peek() == '(' && key == ')') || (stack.Peek() == '[' && key == ']') || (stack.Peek() == '{' && key == '}'))
                        stack.Pop();
                    else return false;
                }
            }
            if (stack.Count > 0) return false;
            return true;
        }
    }
}
