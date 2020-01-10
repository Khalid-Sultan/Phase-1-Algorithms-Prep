using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class Prime_Subtraction
    {
        static void PrimeSubtraction()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                Int64 l = Convert.ToInt64(line[0]);
                Int64 r = Convert.ToInt64(line[1]);
                Int64 difference = l - r;
                if (difference != 1)
                    Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}
