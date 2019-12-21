using System;
using System.Collections.Generic;
using System.Text;

namespace Day_19
{
    class Find_Positive_Integer_Solution_for_a_Given_Equation
    {
        public class CustomFunction
        {
            // Returns f(x, y) for any given positive integers x and y.
            // Note that f(x, y) is increasing with respect to both x and y.
            // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
            public int f(int x, int y) { return 1; }
        };
        public IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
        {
            List<IList<int>> list = new List<IList<int>>();
            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j <= 1000; j++)
                {
                    if (customfunction.f(i, j) == z)
                    {
                        list.Add(new List<int>() { i, j });
                    }
                }
            }
            return list;
        }
    }
}
