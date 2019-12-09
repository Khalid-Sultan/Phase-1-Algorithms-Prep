using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12
{
    class Number_of_Recent_Calls
    {
        Queue<int> pings = new Queue<int>();
        public int Ping(int t)
        {
            pings.Enqueue(t);
            while (pings.Peek() < t - 3000) pings.Dequeue();
            return pings.Count;
        }
    }
}
