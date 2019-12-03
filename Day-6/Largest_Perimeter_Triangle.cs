using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class Largest_Perimeter_Triangle
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

        public int LargestPerimeter(int[] A)
        {
            int[] A2 = mergeSort(A, 0, A.Length - 1);
            int maxLength = A2.Length - 3;
            for (int i = maxLength; i >= 0; --i)
            {
                int side_1 = A2[i];
                int side_2 = A2[i + 1];
                int side_3 = A2[i + 2];
                if (side_1 + side_2 > side_3)
                    return side_1 + side_2 + side_3;
            }
            return 0;
        }
    }
}
