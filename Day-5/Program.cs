using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_5
{
    class Program
    {

        //SELECTION SORT


        public static int[] selectionSort(int[] randomArray)
        {
            for(int i = 0; i< randomArray.Length; i++)
            {
                int min = randomArray[i];
                int min_index = i;
                for(int j = i; j < randomArray.Length; j++)
                {
                    if (i == j) continue;
                    if (randomArray[j] < min )
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


        //MERGE SORT


        public static int[] mergeSort(int[] randomArray, int low=0, int high=9999)
        {
            int mid;
            if (low < high)
            {
                mid = (low + high) / 2;
                mergeSort(randomArray, low, mid);
                mergeSort(randomArray, mid + 1, high);
                int[] final_result = merging(low, mid, high,randomArray);
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
                while (randomArray[++leftPointer] < pivot){}

                while (rightPointer > 0 && randomArray[--rightPointer] > pivot){}

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
            for(int i = 0; i< 30; i++)
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
            Random rnd = new Random();
            //int[] randomArray_for_selection = Enumerable.Range(0, 10000).OrderBy(c => rnd.Next()).ToArray();
            //Console.WriteLine("RANDOM ARRAY FOR SELECTION");
            //PrintArray(randomArray_for_selection);

            //Console.WriteLine("SELECTION SORTED ARRAY");
            //int[] selectedSort = selectionSort(randomArray_for_selection);
            //PrintArray(selectedSort);


            //int[] randomArray_for_insertion = Enumerable.Range(0, 10000).OrderBy(c => rnd.Next()).ToArray();
            //Console.WriteLine("RANDOM ARRAY FOR INSERTION");
            //PrintArray(randomArray_for_insertion);

            //Console.WriteLine("INSERTION SORTED ARRAY");
            //int[] insertedSort = insertionSort(randomArray_for_insertion);
            //PrintArray(insertedSort);

            //int[] randomArray_for_merge = Enumerable.Range(0, 10000).OrderBy(c => rnd.Next()).ToArray();
            //Console.WriteLine("RANDOM ARRAY FOR MERGE");
            //PrintArray(randomArray_for_merge);

            //Console.WriteLine("MERGE SORTED ARRAY");
            //int[] mergedSort = mergeSort(randomArray:randomArray_for_merge);
            //PrintArray(mergedSort);

            int[] randomArray_for_quick = Enumerable.Range(0, 10000).OrderBy(c => rnd.Next()).ToArray();
            Console.WriteLine("RANDOM ARRAY FOR QUICK");
            PrintArray(randomArray_for_quick);

            Console.WriteLine("QUICK SORTED ARRAY");
            quickSort(randomArray: randomArray_for_quick);
            PrintArray(randomArray_for_quick);
        }
    }
    }
