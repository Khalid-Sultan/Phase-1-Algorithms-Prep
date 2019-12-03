using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9
{
    class Implement_Queue_Using_Stacks
    {
        Stack<int> stack = new Stack<int>();

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            stack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            Stack<int> backup = new Stack<int>();
            foreach (int element in stack) backup.Push(element);
            int first_element = backup.Pop();
            stack.Clear();
            foreach (int element in backup) stack.Push(element);
            return first_element;
        }

        /** Get the front element. */
        public int Peek()
        {
            Stack<int> backup = new Stack<int>();
            foreach (int element in stack) backup.Push(element);
            int first_element = backup.Peek();
            return first_element;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stack.Count > 0 ? false : true;
        }
    }
}
