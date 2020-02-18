using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Maximum_Subarray
    {
        public class Solution
        {
            public int MaxSubArray(int[] nums)
            {
                int[] saved = new int[nums.Length];
                saved[0] = nums[0];
                int max = saved[0];

                for (int i = 1; i < nums.Length; i++)
                {
                    if (saved[i - 1] > 0)
                    {
                        saved[i] = nums[i] + saved[i - 1];
                    }
                    else
                    {
                        saved[i] = nums[i];
                    }
                    max = Math.Max(max, saved[i]);
                }
                return max;
            }
        }
    }
}
