using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class Question_2
    {
        public int[] countingSort(int[] randomArray)
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

        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            int[] sorted_arr1 = countingSort(arr1);
            int[] resultArray = new int[sorted_arr1.Length + arr2.Length];

            int found = 0;
            int index = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                int currentMax = arr2[i];
                for (int j = 0; j < sorted_arr1.Length; j++)
                {
                    if (sorted_arr1[j] < currentMax) continue;
                    if (sorted_arr1[j] > currentMax)
                    {
                        if (found == 0)
                        {
                            resultArray[index] = currentMax;
                            index += 1;
                        }
                        found = 0;
                        break;
                    }
                    else if (sorted_arr1[j] == currentMax)
                    {
                        resultArray[index] = sorted_arr1[j];
                        index += 1;
                        sorted_arr1[j] = -1;
                        found = 1;
                        continue;
                    }
                }
            }
            int size = 0;
            for (int i = 0; i < sorted_arr1.Length; i++)
            {
                if (sorted_arr1[i] == -1)
                {
                    size += 1;
                    continue;
                }
                resultArray[index] = sorted_arr1[i];
                index += 1;
                size += 1;
            }
            return resultArray;

        }
    }
}
