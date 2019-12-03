using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_5
{
    class Efficient_Randomization
    {
        public static void PrintArray(int[] randomArray)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.Write($"{randomArray[i]} , ");
            }
            Console.WriteLine("\n");
        }
        static void Randomize<T>(T[] items)
        {
            Random rand = new Random();
            for (int i = 0; i < items.Length - 1; i++)
            {
                int j = rand.Next(i, items.Length);
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] random = Enumerable.Range(0, 50).ToArray();
            Randomize(random);
            Console.WriteLine("RANDOMIZED ARRAY");
            PrintArray(random); 
        }
    }
}
