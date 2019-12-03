using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_4
{
    class Quick_Sort
    {
        //QUICK SORT

        public static void quickSort(int[] randomArray, int left = 0, int right = 9999)
        {
            if (right - left <= 0)
            {
                return;
            }
            else
            {
                int pivot = randomArray[right];
                int partitionPoint = partition(left, right, pivot, randomArray);
                quickSort(randomArray, left, partitionPoint - 1);
                quickSort(randomArray, partitionPoint + 1, right);
            }
        }
        public static int partition(int left, int right, int pivot, int[] randomArray)
        {
            int leftPointer = left - 1;
            int rightPointer = right;

            while (true)
            {
                while (randomArray[++leftPointer] < pivot) { }

                while (rightPointer > 0 && randomArray[--rightPointer] > pivot) { }

                if (leftPointer >= rightPointer) break;
                else
                {
                    int temp_2 = randomArray[leftPointer];
                    randomArray[leftPointer] = randomArray[rightPointer];
                    randomArray[rightPointer] = temp_2;
                }
            }
            int temp = randomArray[leftPointer];
            randomArray[leftPointer] = randomArray[right];
            randomArray[right] = temp;
            return leftPointer;
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
            int[] randomArray_for_quick = Enumerable.Range(0, 10000).ToArray();
            Randomize(randomArray_for_quick);
            Console.WriteLine("RANDOM ARRAY FOR QUICK");
            PrintArray(randomArray_for_quick);

            Console.WriteLine("QUICK SORTED ARRAY");
            quickSort(randomArray: randomArray_for_quick);
            PrintArray(randomArray_for_quick);
        }

    }
}
