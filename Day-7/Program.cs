using System;
using System.Collections.Generic;

namespace Day_7
{
    public class MinStack
    {
        Stack<int> currentStack = new Stack<int>();
        Queue<int> backup = new Queue<int>();
        int min = 0;
        public MinStack()
        {
        }
        public void Push(int x)
        {
            backup.Clear();
            if (currentStack.Count == 0)
            {
                currentStack.Push(x);
            }
            else
            {
                if (currentStack.Peek() <= x) currentStack.Push(x);
                else
                {
                    int found = 0;
                    while (currentStack.Count > 0)
                    {
                        if (currentStack.Peek() <= x && found == 0)
                        {
                            found = 1;
                            backup.Enqueue(currentStack.Pop());
                            backup.Enqueue(x);
                        }
                        else
                            backup.Enqueue(currentStack.Pop());
                    }
                    currentStack.Clear();
                    while (backup.Count > 0)
                        if (backup.Count == 1) min = backup.Peek();
                        currentStack.Push(backup.Dequeue());
                }
            }
        }

        public void Pop()
        {
            currentStack.Pop();
        }

        public int Top()
        {
            return currentStack.Peek();
        }

        public int GetMin()
        {
            return min;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Console.WriteLine(minStack.GetMin());
            minStack.Pop();
            Console.WriteLine(minStack.Top());
            Console.WriteLine(minStack.GetMin());
        }
    }
}
