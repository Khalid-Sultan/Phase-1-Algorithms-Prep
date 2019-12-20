using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace TopCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            char[] string_to_char = Console.ReadLine().ToCharArray();

            int[] mins = new int[string_to_char.Length];
            for(int i = 0; i < string_to_char.Length; i++)
            {
                if (i == 0) mins[i]++;
                int removed = 0;
                int currentMin = Convert.ToInt32(string_to_char[i]);
                for(int j=i+1; j < string_to_char.Length; j++)
                {
                    int next = Convert.ToInt32(string_to_char[j]);
                    if (next == currentMin + 1) mins[i]++;
                    
                    else if(removed==1) break;
                }
            }
            int max = mins[0];
            foreach(int m in mins)
            {
                if (m > max) max = m;
            }
            Console.WriteLine(max);
        }
    }
}
