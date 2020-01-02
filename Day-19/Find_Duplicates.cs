using System;
using System.Collections.Generic;
using System.Text;

namespace Day_19
{
    class Find_Duplicates
    {
        public int FindDuplicate(int[] nums)
        {
            int low = 1;
            int high = nums.Length;
            while (low < high)
            {
                int mid = (low + high) / 2;
                int s = 0;
                foreach (int i in nums)
                {
                    if (i <= mid && i >= low) s++;
                }
                if (mid - low + 1 < s) high = mid;
                else low = mid + 1;
            }
            return low;

        }
    }
}
