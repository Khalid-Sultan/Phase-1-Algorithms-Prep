using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_5
{
    class Counting_Sort
    {
        public static int[] countingSort(int[] randomArray)
        {
            int max_range = 0;
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (max_range < randomArray[i]) max_range = randomArray[i];
            }
            int[] counting_array = new int[max_range + 1];
            for (int i = 0; i < max_range + 1; i++)
            {
                counting_array[i] = 0;
            }
            for (int i = 0; i < randomArray.Length; i++)
            {
                int check = randomArray[i];
                counting_array[check] += 1;
            }
            int[] final_array = new int[randomArray.Length];
            int index = 0;
            for (int i = 0; i < counting_array.Length; i++)
            {
                if (counting_array[i] == 0) continue;
                for (int j = 0; j < counting_array[i]; j++)
                {
                    final_array[index] = i;
                    index += 1;
                }
            }
            return final_array;
        }

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
            int[] randomArray_for_counting = Enumerable.Range(0, 50).ToArray();
            Randomize(randomArray_for_counting);
            Console.WriteLine("RANDOM ARRAY FOR COUNTING");
            PrintArray(randomArray_for_counting);

            Console.WriteLine("COUNTING SORTED ARRAY");
            int[] sorted = countingSort(randomArray_for_counting);
            PrintArray(sorted);
        }
    }
}
