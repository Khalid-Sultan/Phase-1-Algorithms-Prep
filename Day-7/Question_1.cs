using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_7
{
    class Question_1
    {
        public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }
        public int CalculateDistance(int[] point)
        {
            return point[0] * point[0] + point[1] * point[1];
        }
        public int[][] KClosest(int[][] points, int K)
        {
            // int[][] result = new int[K][];
            // int[] distances = new int[points.Length];
            // int index = 0;
            // foreach(int[] point in points){
            //     int distance = CalculateDistance(point);
            //     distances[index++]=distance;
            // }
            // // quickSort(distances,0, distances.Length-1);
            // int index_2 = 0;
            // foreach(int[] point in points){
            //     if(CalculateDistance(point)<=distances[K-1])
            //         result[index_2++] = point;
            // }
            return points
            .OrderBy(p => Math.Pow(Math.Abs(p[0]), 2) + Math.Pow(Math.Abs(p[1]), 2))
            .Take(K)
            .ToArray();
        }
    }
}
