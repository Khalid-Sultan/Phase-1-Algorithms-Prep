using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_4
{
    class Selection_Sort
    {
        //SELECTION SORT
        public static int[] selectionSort(int[] randomArray)
        {
            for (int i = 0; i < randomArray.Length; i++)
            {
                int min = randomArray[i];
                int min_index = i;
                for (int j = i; j < randomArray.Length; j++)
                {
                    if (i == j) continue;
                    if (randomArray[j] < min)
                    {
                        min = randomArray[j];
                        min_index = j;
                    }
                }
                int temp = randomArray[i];
                randomArray[i] = min;
                randomArray[min_index] = temp;
            }
            return randomArray;
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
            int[] randomArray_for_selection = Enumerable.Range(0, 10000).ToArray();
            Randomize(randomArray_for_selection);
            Console.WriteLine("RANDOM ARRAY FOR SELECTION");
            PrintArray(randomArray_for_selection);

            Console.WriteLine("SELECTION SORTED ARRAY");
            int[] selectedSort = selectionSort(randomArray_for_selection);
            PrintArray(selectedSort); 
        }
    }
}
