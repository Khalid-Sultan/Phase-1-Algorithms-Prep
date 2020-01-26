using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Question_1_Two_Sum
    {
        /*
        Given an array of integers return indices of the two numbers such that
        they add up to a specific target.
        You may assume that each input would have exactly one solution, and you
        may not use the same element twice.
        Example:
        Given nums = [2, 7, 11, 15], target = 9,
        Because nums[0] + nums[1] = 2 + 7 = 9
        return [0, 1].
        */
        static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[] { };
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for(int i = 0; i<nums.Length; i++)
            {
                int diffrence = target - nums[i];
                if (keyValuePairs.ContainsKey(diffrence))
                {
                    return new int[] {keyValuePairs[diffrence], i};
                }
                keyValuePairs.Add(nums[i], i);
            }
            return new int[] { };
        }
        static void PrintArrayInALine(int[] nums)
        {
            foreach(int i in nums)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
        }

        //static void Main(string[] args)
        //{
        //    PrintArrayInALine(TwoSum(new int[] { 2, 7, 11, 15 }, 9));
        //}
    }
}
