using System;
using System.Collections.Generic;

namespace Day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = {"-","+", "*", "30","3", "12","6"};
            Stack<char> operations = new Stack<char>();
            Stack<int> operands = new Stack<int>();

            double sum = 0d;

            foreach(string character in word)
            {
                switch (character)
                {
                    case "+":
                        if (operands.Count == 1)
                        {
                            int firstnumber = operands.Pop();
                            char op = operations.Pop();
                            if (op == '+')
                            {
                                sum += firstnumber;
                            }
                            else if (op == '-')
                            {
                                sum -= firstnumber;
                            }
                            else if (op == '*')
                            {
                                sum *= firstnumber;
                            }
                            else if (op == '/')
                            {
                                sum /= firstnumber;
                            }
                        }
                        operations.Push('+');
                        break;
                    case "-":
                        if (operands.Count == 1)
                        {
                            int firstnumber = operands.Pop();
                            char op = operations.Pop();
                            if (op == '+')
                            {
                                sum += firstnumber;
                            }
                            else if (op == '-')
                            {
                                sum -= firstnumber;
                            }
                            else if (op == '*')
                            {
                                sum *= firstnumber;
                            }
                            else if (op == '/')
                            {
                                sum /= firstnumber;
                            }
                        }
                        operations.Push('-');
                        break;
                    case "*":
                        if (operands.Count == 1)
                        {
                            int firstnumber = operands.Pop();
                            char op = operations.Pop();
                            if (op == '+')
                            {
                                sum += firstnumber;
                            }
                            else if (op == '-')
                            {
                                sum -= firstnumber;
                            }
                            else if (op == '*')
                            {
                                sum *= firstnumber;
                            }
                            else if (op == '/')
                            {
                                sum /= firstnumber;
                            }
                        }
                        operations.Push('*');
                        break;
                    case "/":
                        if (operands.Count == 1)
                        {
                            int firstnumber = operands.Pop();
                            char op = operations.Pop();
                            if (op == '+')
                            {
                                sum += firstnumber;
                            }
                            else if (op == '-')
                            {
                                sum -= firstnumber;
                            }
                            else if (op == '*')
                            {
                                sum *= firstnumber;
                            }
                            else if (op == '/')
                            {
                                sum /= firstnumber;
                            }
                        }
                        operations.Push('/');
                        break;
                    default:
                        operands.Push(Convert.ToInt32(character));
                        if (operands.Count == 2)
                        {
                            int firstnumber = operands.Pop();
                            int secondnumber = operands.Pop();
                            char op = operations.Pop();
                            if (op == '+')
                            {
                                double result = firstnumber + secondnumber;
                                sum += result;
                            }
                            else if (op == '-')
                            {
                                double result = firstnumber - secondnumber;
                                sum += result;
                            }
                            else if (op == '*')
                            {
                                double result = firstnumber * secondnumber;
                                sum += result;
                            }
                            else if (op == '/')
                            {
                                double result = firstnumber / secondnumber;
                                sum += result;
                            }
                        }
                        break;
                }
            }
            Console.WriteLine($"Result is {sum}");

        }
    }
}
