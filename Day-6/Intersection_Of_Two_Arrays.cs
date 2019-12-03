using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class Intersection_Of_Two_Arrays
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

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            int[] sorted1 = countingSort(nums1);
            int[] sorted2 = countingSort(nums2);
            int max = 0;
            for (int i = 0; i < sorted1.Length; i++)
            {
                if (max < sorted1[i]) max = sorted1[i];
            }
            for (int i = 0; i < sorted2.Length; i++)
            {
                if (max < sorted2[i]) max = sorted2[i];
            }
            int[] maximo = new int[max + 1];
            for (int i = 0; i < max; i++)
            {
                maximo[i] = 0;
            }
            for (int i = 0; i < sorted1.Length; i++)
            {
                for (int j = 0; j < sorted2.Length; j++)
                {
                    if (sorted1[i] == sorted2[j]) maximo[sorted2[j]] = 1;
                }
            }
            int size = 0;
            for (int i = 0; i <= max; i++)
            {
                if (maximo[i] == 1) size += 1;
            }
            int[] result = new int[size];
            int index = 0;
            for (int i = 0; i <= max; i++)
            {
                if (maximo[i] == 1)
                {
                    result[index] = i;
                    index += 1;
                }
            }
            return result;
        }
    }
}
