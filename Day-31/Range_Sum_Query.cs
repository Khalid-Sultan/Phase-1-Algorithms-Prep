using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Range_Sum_Query
    {
        public class NumArray
        {
            private int[] sum;
            public NumArray(int[] nums)
            {
                this.sum = new int[nums.Length + 1];
                for (int i = 0; i < nums.Length; i++)
                {
                    this.sum[i + 1] = nums[i] + this.sum[i];
                }
            }

            public int SumRange(int i, int j)
            {
                return this.sum[j + 1] - this.sum[i];
            }
        }

        /**
         * Your NumArray object will be instantiated and called as such:
         * NumArray obj = new NumArray(nums);
         * int param_1 = obj.SumRange(i,j);
         */
    }
}
