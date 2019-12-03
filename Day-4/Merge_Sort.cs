using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_4
{
    class Merge_Sort
    {




        //MERGE SORT


        public static int[] mergeSort(int[] randomArray, int low = 0, int high = 9999)
        {
            int mid;
            if (low < high)
            {
                mid = (low + high) / 2;
                mergeSort(randomArray, low, mid);
                mergeSort(randomArray, mid + 1, high);
                int[] final_result = merging(low, mid, high, randomArray);
                return final_result;
            }
            else
            {
                return randomArray;
            }
        }
        public static int[] merging(int low, int mid, int high, int[] randomArray)
        {
            int[] finalResult = new int[randomArray.Length];
            int l1, l2, i;
            for (l1 = low, l2 = mid + 1, i = low; l1 <= mid && l2 <= high; i++)
            {
                if (randomArray[l1] <= randomArray[l2])
                    finalResult[i] = randomArray[l1++];
                else
                    finalResult[i] = randomArray[l2++];
            }

            while (l1 <= mid)
                finalResult[i++] = randomArray[l1++];

            while (l2 <= high)
                finalResult[i++] = randomArray[l2++];

            for (i = low; i <= high; i++)
                randomArray[i] = finalResult[i];
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
            int[] randomArray_for_merge = Enumerable.Range(0, 10000).ToArray();
            Randomize(randomArray_for_merge);
            Console.WriteLine("RANDOM ARRAY FOR MERGE");
            PrintArray(randomArray_for_merge);

            Console.WriteLine("MERGE SORTED ARRAY");
            int[] mergedSort = mergeSort(randomArray: randomArray_for_merge);
            PrintArray(mergedSort);
        }
    }
}
