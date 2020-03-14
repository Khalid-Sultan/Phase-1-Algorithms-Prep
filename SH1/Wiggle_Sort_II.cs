using System;
using System.Collections.Generic;
using System.Text;

namespace SH1
{
    class Wiggle_Sort_II
    {
        public void WiggleSort(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return;
            }

            int len = nums.Length;
            int left = 0;
            int right = len - 1;
            int i = 0;
            int mid = findMedian(0, len - 1, len / 2, nums);
            while (i <= right)
            {
                int mappedCurIndex = newIndex(i, len);
                if (nums[mappedCurIndex] > mid)
                {
                    int mappedLeftIndex = newIndex(left, len);
                    swap(mappedLeftIndex, mappedCurIndex, nums);
                    left++; i++;
                }
                else if (nums[mappedCurIndex] < mid)
                {
                    int mappedRightIndex = newIndex(right, len);
                    swap(mappedCurIndex, mappedRightIndex, nums);
                    right--;
                }
                else
                {
                    i++;
                }
            }
        }
        public int findMedian(int start, int end, int k, int[] nums)
        {
            if (start > end)
            {
                return int.MaxValue;
            }
            int pivot = nums[end];
            int indexOfWall = start;
            for (int i = start; i < end; i++)
            {
                if (nums[i] <= pivot)
                {
                    swap(i, indexOfWall, nums);
                    indexOfWall++;
                }
            }
            swap(indexOfWall, end, nums);
            if (indexOfWall == k)
            {
                return nums[indexOfWall];
            }
            else if (indexOfWall < k)
            {
                return findMedian(indexOfWall + 1, end, k, nums);
            }
            else
            {
                return findMedian(start, indexOfWall - 1, k, nums);
            }
        }
        public void swap(int i, int j, int[] nums)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        public int newIndex(int index, int len)
        {
            return (1 + 2 * index) % (len | 1);
        }
    }
}