using System;
using System.Collections.Generic;
using System.Text;

namespace Day_24
{
    class Contains_Duplicate_II
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            HashSet<int> keyValuePairs = new HashSet<int>();
            for(int i = 0; i<nums.Length; i++)
            {
                int current_num = nums[i];
                if (keyValuePairs.Contains(current_num)) return true;
                keyValuePairs.Add(nums[i]);
                if (i >= k) keyValuePairs.Remove(nums[i - k]);
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3));
            Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1));
            Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2));
            Console.WriteLine(ContainsNearbyDuplicate(new int[] { 99, 99}, 2));
        }

    }
}
