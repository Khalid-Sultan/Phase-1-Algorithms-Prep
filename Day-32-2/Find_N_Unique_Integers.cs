using System;
using System.Collections.Generic;
using System.Text;

namespace Day_32_2
{
    class Find_N_Unique_Integers
    {
        public int[] SumZero(int n)
        {
            int[] result = new int[n];
            int counter = 1;
            if (n % 2 == 0)
            {
                for (int i = 0; i < n; i += 2)
                {
                    result[i] = counter;
                    result[i + 1] = -1 * counter;
                    counter++;
                }
            }
            else
            {
                result[0] = 0;
                for (int i = 1; i < n; i += 2)
                {
                    result[i] = counter;
                    result[i + 1] = -1 * counter;
                    counter++;
                }
            }
            return result;
        }

    }
}
