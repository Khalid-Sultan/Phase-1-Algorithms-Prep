using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9
{
    class Question_3
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> Operands = new Stack<int>();
            int result = 0;
            foreach (string c in tokens)
            {
                if (c == "+" || c == "-" || c == "*" || c == "/")
                {
                    int second_number = Operands.Pop();
                    int first_number = Operands.Pop();
                    if (c == "+")
                    {
                        Operands.Push(first_number + second_number);
                    }
                    else if (c == "-")
                    {
                        Operands.Push(first_number - second_number);
                    }
                    else if (c == "*")
                    {
                        Operands.Push(first_number * second_number);
                    }
                    else
                    {
                        Operands.Push(first_number / second_number);
                    }
                }
                else
                {
                    Operands.Push(Convert.ToInt32(c));
                }
            }
            return Operands.Pop();
        }
    }
}
