using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_10
{
    class Daily_Temperatures
    {
        public static void Main(String[] args)
        {
            int[] T = { 73, 74, 75, 71, 69, 72, 76, 73 };
            int[] result = new int[T.Length];
            for(int i = 0; i< result.Length; i++)
            {
                Stack<int> original = new Stack<int>();
                int found = 0;
                for (int j = i; j < T.Length; j++)
                {
                    if (T[j] > T[i])
                    {
                        found = 1;
                        break;
                    }
                    original.Push(T[j]);
                }
                if (found == 1)
                    result[i] = original.Count;
                else
                    result[i] = 0;
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]} , ");
            }
            Console.WriteLine("\n");
        }
    }
}
