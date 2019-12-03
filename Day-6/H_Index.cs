using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class H_Index
    {
        public int[] mergeSort(int[] randomArray, int low, int high)
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
        public int[] merging(int low, int mid, int high, int[] randomArray)
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
        public int HIndex(int[] citations)
        {
            int[] sortedArray = mergeSort(citations, 0, citations.Length - 1);
            int n = sortedArray.Length;
            int i = 0;
            while (i < n && sortedArray[i] < (n - i)) i++;
            return n - i;
        }
    }
}
