using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_5
{
    class Radix_Sort
    {
        //RADIX SORT

        public static int[] radixSort(int[] randomArray)
        {
            int[] tmp = new int[randomArray.Length];
            int i, j;
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < randomArray.Length; ++i)
                {
                    bool move = (randomArray[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        randomArray[i - j] = randomArray[i];
                    else
                        tmp[j++] = randomArray[i];
                }
                Array.Copy(tmp, 0, randomArray, randomArray.Length - j, j);
            }

            return randomArray;
        }


        public static void PrintArray(int[] randomArray)
        {
            for (int i = 0; i < randomArray.Length; i++)
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
            int[] randomArray_for_radix = Enumerable.Range(0, 10000).ToArray();
            Randomize(randomArray_for_radix);
            Console.WriteLine("RANDOM ARRAY FOR RADIX");
            PrintArray(randomArray_for_radix);

            Console.WriteLine("RADIX SORTED ARRAY");
            int[] radixSorted = radixSort(randomArray_for_radix);
            PrintArray(radixSorted);

        }
    }
}
