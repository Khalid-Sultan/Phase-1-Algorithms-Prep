using System;
using System.Collections.Generic;
using System.Text;

namespace SH1
{
    class Search_In_A_Rotated_Array
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }
            int left = 0;
            int right = nums.Length - 1;

            if (target > nums[right] && target < nums[left])
            {
                return -1;
            }
            if (target >= nums[left])
            {
                return BinarySearch(nums, left, right, target, true);
            }
            else if (target <= nums[right])
            {
                return BinarySearch(nums, left, right, target, false);
            }
            return -1;
        }

        public int BinarySearch(int[] nums, int left, int right, int target, bool isLeft)
        {
            if (left > right)
            {
                return -1;
            }
            int mid = left + (right - left) / 2;

            if (isLeft)
            {
                while (nums[mid] < nums[left])
                {
                    mid--;
                }
                if (target > nums[mid])
                {
                    return BinarySearch(nums, mid + 1, right, target, true);
                }
                else if (target < nums[mid])
                {
                    return BinarySearch(nums, left, mid - 1, target, true);
                }
                else if (target == nums[mid])
                {
                    return mid;
                }
            }
            else
            {
                while (nums[mid] > nums[right])
                {
                    mid++;
                }
                if (target > nums[mid])
                {
                    return BinarySearch(nums, mid + 1, right, target, false);
                }
                else if (target < nums[mid])
                {
                    return BinarySearch(nums, left, mid - 1, target, false);
                }
                else if (target == nums[mid])
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}