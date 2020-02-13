using System;
using System.Text;

namespace Day_34
{
    class Program
    {
        static void Main(string[] args)
        {
            int test_cases = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<test_cases; i++)
            {
                string[] test = Console.ReadLine().Split(' ');
                long length = Convert.ToInt64(test[0]);
                long good = Convert.ToInt64(test[1]);
                long bad = Convert.ToInt64(test[2]);

                if (length < good)
                {
                    Console.WriteLine(length);
                    continue;
                }
                long counter = 0;
                if (length % 2 == 0)
                {
                    long temp = length / 2;
                    for(long j = 0; j<temp; j++)
                    {
                        counter += good;
                        length -= good;
                        counter += bad;
                        length -= bad;
                    }
                    if (length != 0)
                    {
                        counter = Math.Abs(length);
                    }
                }
                else
                {
                    long temp = (length / 2 )+ 1;
                    for (long j = 0; j < temp; j++)
                    {
                        counter += good;
                        length -= good;
                        counter += bad;
                        length -= bad;
                    }
                    counter += length;
                }
                Console.WriteLine(counter);
            }
        }
    }
}
