using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class House_Robber
    {
        public class Solution
        {
            public int Rob(int[] nums)
            {
                int[] dp = new int[nums.Length + 1];
                for (int i = 0; i <= nums.Length; i++)
                {
                    dp[i] = -1;
                }
                return Rob(nums, dp, nums.Length - 1);
            }

            private int Rob(int[] nums, int[] dp, int i)
            {
                if (i < 0)
                {
                    return 0;
                }
                if (dp[i] >= 0)
                {
                    return dp[i];
                }
                int result = Math.Max(Rob(nums, dp, i - 2) + nums[i], Rob(nums, dp, i - 1));
                dp[i] = result;
                return result;
            }
        }
    }
}
