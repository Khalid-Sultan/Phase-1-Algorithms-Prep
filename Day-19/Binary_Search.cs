using System;
using System.Collections.Generic;
using System.Text;

namespace Day_19
{
    class Binary_Search
    {
        public int Search(int[] nums, int target)
        {
            int lowest = 0;
            int max = nums.Length - 1;
            while (lowest <= max)
            {
                if (nums[lowest + ((max - lowest) / 2)] == target)
                {
                    return lowest + ((max - lowest) / 2);
                }
                else if (nums[lowest + ((max - lowest) / 2)] < target)
                {
                    lowest = 1 + lowest + ((max - lowest) / 2);
                }
                else
                {
                    max = -1 + lowest + ((max - lowest) / 2);
                }
            }
            return -1;
        }
    }
}
