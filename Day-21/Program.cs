using System;
using System.Collections.Generic;

namespace Day_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int test_cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < test_cases; i++)
            {
                Console.ReadLine();

                string[] values = Console.ReadLine().Split(' ');
                List<int> presents_stack = new List<int>();
                foreach (string v in values) presents_stack.Add(Convert.ToInt32(v));

                string[] values3 = Console.ReadLine().Split(' ');
                List<int> presents_order = new List<int>();
                foreach (string v in values3) presents_order.Add(Convert.ToInt32(v));

                int result = 0;
                Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
                foreach (int i_v in presents_order)
                {
                    keyValuePairs.Add(i_v, presents_stack.IndexOf(i_v));
                }

                int last_removed = keyValuePairs[presents_order[0]];
                int diff = 0;
                foreach (int ij in presents_order)
                {
                    if (keyValuePairs[ij] < last_removed)
                        result++;
                    else if (keyValuePairs[ij] == last_removed)
                        result += 2 * keyValuePairs[ij] - diff + 1;
                    else
                    {
                        last_removed = keyValuePairs[ij];
                        result += 2 * last_removed - diff;
                    }
                    diff++;
                }

                Console.WriteLine(result);
            }


        }
    }
}
