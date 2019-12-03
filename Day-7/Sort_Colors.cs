using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    class Sort_Colors
    {
        public void SortColors(int[] nums)
        {
            int last_found_0 = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (last_found_0 == -1)
                    {
                        int temp = nums[0];
                        nums[0] = nums[i];
                        nums[i] = temp;
                        last_found_0 = 1;
                    }
                    else
                    {
                        int temp = nums[last_found_0];
                        nums[last_found_0] = nums[i];
                        nums[i] = temp;
                        last_found_0 += 1;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    if (last_found_0 == -1)
                    {
                        int temp = nums[0];
                        nums[0] = nums[i];
                        nums[i] = temp;
                        last_found_0 = 1;
                    }
                    else
                    {
                        int temp = nums[last_found_0];
                        nums[last_found_0] = nums[i];
                        nums[i] = temp;
                        last_found_0 += 1;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2)
                {
                    if (last_found_0 == -1)
                    {
                        int temp = nums[0];
                        nums[0] = nums[i];
                        nums[i] = temp;
                        last_found_0 = 1;
                    }
                    else
                    {
                        int temp = nums[last_found_0];
                        nums[last_found_0] = nums[i];
                        nums[i] = temp;
                        last_found_0 += 1;
                    }
                }
            }
        }
    }
}
