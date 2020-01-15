using System;
using System.Collections.Generic;
using System.Text;

namespace Day_24
{
    class Powerful_Integers
    {
        public class Solution
        {
            public IList<int> PowerfulIntegers(int x, int y, int bound)
            {
                HashSet<int> result = new HashSet<int>();
                int b = 0;
                if (x == 1 || y == 1)
                {
                    b = Math.Max(x, y);
                }
                else
                {
                    b = Math.Min(x, y);
                }

                int n = 1;
                if (b != 1)
                    while (Math.Pow(b, n) <= bound)
                        n++;

                for (int i = 0; i <= n; i++)
                {
                    for (int j = 0; j <= n; j++)
                    {
                        int val = (int)(Math.Pow(x, i) + Math.Pow(y, j));
                        if (val <= bound)
                            result.Add(val);
                    }
                }
                return new List<int>(result);
            }
        }
    }
}
