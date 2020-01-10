using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class Find_Divisible
    {
        public void FindDivisible()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int l = Convert.ToInt32(line[0]);
                int r = Convert.ToInt32(line[1]);
                if (l == r || l == 1) Console.WriteLine($"{l} {r}");
                else Console.WriteLine($"{l} {2 * l}");
            }
        }
    }
}
