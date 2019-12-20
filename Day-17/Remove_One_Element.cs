using System;
using System.Collections.Generic;
using System.Text;

namespace Day_17
{
    class Remove_One_Element
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            string[] string_to_char = Console.ReadLine().Split(' ');
            List<int> values = new List<int>();
            Array.ForEach(string_to_char, x => values.Add(Convert.ToInt32(x)));
            Stack<int> stack = new Stack<int>();
            stack.Push(values[0]);
            int last_index = 1;
            int max = 1;
            bool found = false;
            while (stack.Count > 0)
            {
                if (last_index == values.Count)
                {
                    if (stack.Count > max)
                    {
                        max = stack.Count;
                    }
                    break;
                }
                if (values[last_index] > stack.Peek())
                {
                    stack.Push(values[last_index]);
                    last_index++;
                    continue;
                }
                if (found == false)
                {
                    found = true;
                    if (stack.Peek() >= values[last_index])
                    {
                        stack.Pop();
                        stack.Push(values[last_index]);
                        last_index++;
                        continue;
                    }
                    else
                    {
                        if (stack.Count > max)
                        {
                            max = stack.Count;
                        }
                        found = false;
                        stack.Clear();
                        values.RemoveAt(0);
                        stack.Push(values[0]);
                        last_index = 1;
                        continue;
                    }
                }
                if (stack.Count > max)
                {
                    max = stack.Count;
                }
                found = false;
                stack.Clear();
                values.RemoveAt(0);
                stack.Push(values[0]);
                last_index = 1;
            }
            Console.WriteLine(max);
        }
    }
}
