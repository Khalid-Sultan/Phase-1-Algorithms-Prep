using System;
using System.Collections.Generic;
using System.Text;

namespace Day_23
{
    class Just_Eat_It
    {
        static long maxSubArraySum(long[] a, int size)
        {
            long max_so_far = long.MinValue;
            long max_ending_here = 0;

            for (int i = 0; i < size-1; i++)
            {
                max_ending_here += a[i];
                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;
                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            long max_so_far_2 = long.MinValue;
            long max_ending_here_2 = 0;

            for (int i = 1; i < size; i++)
            {
                max_ending_here_2 += a[i];
                if (max_so_far_2 < max_ending_here_2)
                    max_so_far_2 = max_ending_here_2;
                if (max_ending_here_2 < 0)
                    max_ending_here_2 = 0;
            }
            return Math.Max(max_so_far, max_so_far_2);
        }
        static void Main(string[] args)
        {
            int tests = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());

                string[] cupcakes = Console.ReadLine().Split(' ');
                long yassir = 0;
                foreach (string key in cupcakes)
                {
                    yassir += Convert.ToInt64(key);
                }

                long[] cupcakes_long = new long[length];
                for (int j = 0; j < length; j++) cupcakes_long[j] = Convert.ToInt64(cupcakes[j]);

                if (maxSubArraySum(cupcakes_long, length) >= yassir) Console.WriteLine("NO");
                else Console.WriteLine("YES");
            }
        }
    }
}
