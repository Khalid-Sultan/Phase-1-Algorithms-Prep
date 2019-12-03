using System;
using System.Collections.Generic;

namespace Day_10
{
    class Min_Stack
    {
        List<int> list = new List<int>();
        public void Push(int x)
        {
            list.Add(x);
        }

        public void Pop()
        {
            list.RemoveAt(list.Count - 1);
        }

        public int Top()
        {
            return list[list.Count - 1];
        }

        public int GetMin()
        {
            int min = list[0];
            foreach (int item in list)
            {
                if (item < min) min = item;
            }
            return min;
        }
    }
}
