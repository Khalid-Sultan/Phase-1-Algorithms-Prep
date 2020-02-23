using System;
using System.Collections.Generic;
using System.Text;

namespace Day_34
{
    class Q_2
    {
        static void check()
        {
            int test_cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < test_cases; i++)
            {
                string[] test = Console.ReadLine().Split(' ');
                long length = Convert.ToInt64(test[0]);
                long good = Convert.ToInt64(test[1]);
                long bad = Convert.ToInt64(test[2]);

                double half_double = length / 2;
                double quarter_double = half_double / good;
                long half = Convert.ToInt64(Math.Ceiling(half_double));
                long cycles = Convert.ToInt64(Math.Ceiling(quarter_double));
                long time = good * (cycles - 1) + bad * (cycles - 1);
                Console.WriteLine(Math.Max(length, half % good > 0 ? time + half % good : time + good));
            }

        }

        //static void Main(string[] args)
        //{
        //    check();
        //}
    }
}
