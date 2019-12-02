using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_6
{
    class Program
    {

        //COUNTING SORT

        public static int[] countingSort(int[] randomArray)
        {
            int max_range = 0;
            for(int i = 0; i <randomArray.Length; i++)
            {
                if (max_range < randomArray[i]) max_range = randomArray[i];
            }
            int[] counting_array = new int[max_range+1];
            for(int i = 0; i< max_range+1; i++)
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
            for(int i = 0; i<counting_array.Length; i++)
            {
                if (counting_array[i] == 0) continue;
                for(int j = 0; j<counting_array[i]; j++)
                {
                    final_array[index] = i;
                    index += 1;
                }
            }
            return final_array;
        }


        //COUNTING SORT INPLACE
        public static int[] countingSortInPlace(int[] randomArray)
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
            int[] accummulator_array = new int[max_range + 1];
            accummulator_array[0] = counting_array[0];
            for(int i = 1; i<max_range+1; i++)
            {
                accummulator_array[i] = accummulator_array[i-1] + counting_array[i];
            }
            int[] final_array = new int[randomArray.Length];
            for (int i = randomArray.Length-1; i >0; i--)
            {
                int current_digit = randomArray[i];
                int current_value = final_array[current_digit-1];
                current_value -= 1;
                final_array[current_value] = current_digit;
            }
            PrintArray(final_array);
            return final_array;
        }

        //RADIX SORT


        public static int[] radixSort(int[] randomArray)
        {
            int[] tmp = new int[randomArray.Length];
            //int i, j;
            //for (int shift = 31; shift > -1; --shift)
            //{
            //    j = 0;
            //    for (i = 0; i < randomArray.Length; ++i)
            //    {
            //        bool move = (randomArray[i] << shift) >= 0;
            //        if (shift == 0 ? !move : move)  
            //            randomArray[i - j] = randomArray[i];
            //        else
            //            tmp[j++] = randomArray[i];
            //    }
            //    Array.Copy(tmp, 0, randomArray, randomArray.Length - j, j);
            //}
            int max_digit = 0;
            for(int i = 0; i< randomArray.Length; i++)
            {
                if (max_digit < randomArray[i]) max_digit = randomArray[i];
            }
            int max_digit_counter = 0;
            while (max_digit > 0)
            {
                max_digit_counter += 1;
                max_digit /= 10;
            }
            int[] tempArray = new int[randomArray.Length];
            for(int i = 0; i<randomArray.Length; i++)
            {
                tempArray[i] = randomArray[i];
            }
            int[] order = new int[tempArray.Length];
            for (int j = 0; j < tempArray.Length; j++)
            {
                order[j] = j;
            }

            for (int i = 0; i < max_digit_counter; i++)
            {
                int[] digits = new int[tempArray.Length];
                for (int j = 0; j < tempArray.Length; j++)
                {
                    digits[j] = tempArray[j] % 10;
                    tempArray[j] /= 10;
                }
                int[] sortedDigits = countingSort(digits);

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
            //int[] randomArray_for_counting = Enumerable.Range(0, 10000).ToArray();
            //Randomize(randomArray_for_counting);
            //Console.WriteLine("RANDOM ARRAY FOR COUNTING SORT");
            //PrintArray(randomArray_for_counting);

            //Console.WriteLine("COUNTING SORTED ARRAY");
            //int[] countSort = countingSort(randomArray_for_counting);
            //PrintArray(countSort);

            int[] randomArray_for_counting = { 0,5,4,2,3,6,5,4,6,3,6,5,4,1,6,5, 3, 6, 5, 4, 1, 6, 5, 3, 6, 5, 4, 1, 6, 5, 1,7,6,7,5,0,1,0,9,1,6,2,5,7,6,9,1,6,4,1};
            Randomize(randomArray_for_counting);
            Console.WriteLine("RANDOM ARRAY FOR COUNTING SORT INPLACE");
            PrintArray(randomArray_for_counting);

            Console.WriteLine("INPLACE COUNTING SORTED ARRAY");
            int[] countSort = countingSortInPlace(randomArray_for_counting);
            PrintArray(countSort);

            //int[] randomArray_for_radix = Enumerable.Range(0, 10000).ToArray();
            //Randomize(randomArray_for_radix);
            //Console.WriteLine("RANDOM ARRAY FOR RADIX");
            //PrintArray(randomArray_for_radix);

            //Console.WriteLine("RADIX SORTED ARRAY");
            //int[] radixSorted = radixSort(randomArray_for_radix);
            //PrintArray(radixSorted);

        }
    }
}
