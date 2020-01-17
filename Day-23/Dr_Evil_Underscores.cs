using System;
using System.Collections.Generic;
using System.Text;  

namespace Day_23
{
    class Dr_Evil_Underscores
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            string[] line = Console.ReadLine().Split();

            List<long> integers = new List<long>();
            foreach (string s in line) integers.Add(Convert.ToInt64(s));

            SortedSet<long> result = new SortedSet<long>();
            foreach (long i in integers)
            {
                SortedSet<long> sorted = new SortedSet<long>();
                foreach (long j in integers)
                {
                    long res = j ^ i;
                    sorted.Add(res);
                }
                result.Add(sorted.Max);
            }
            Console.WriteLine(result.Min);



        }
    }
}
