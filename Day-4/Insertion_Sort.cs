using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_4
{
    class Insertion_Sort
    {

        //INSERTION SORT


        public static int[] insertionSort(int[] randomArray)
        {
            for (int i = 0; i < randomArray.Length; i++)
            {
                int max = randomArray[i];
                int j = i - 1;
                while (j >= 0 && randomArray[j] > max)
                {
                    randomArray[j + 1] = randomArray[j];
                    j = j - 1;
                }
                randomArray[j + 1] = max;
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

            int[] randomArray_for_insertion = Enumerable.Range(0, 10000).ToArray();
            Randomize(randomArray_for_insertion);
            Console.WriteLine("RANDOM ARRAY FOR INSERTION");
            PrintArray(randomArray_for_insertion);

            Console.WriteLine("INSERTION SORTED ARRAY");
            int[] insertedSort = insertionSort(randomArray_for_insertion);
            PrintArray(insertedSort);
        }
    }
}
