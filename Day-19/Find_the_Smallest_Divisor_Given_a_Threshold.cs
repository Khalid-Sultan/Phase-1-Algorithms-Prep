using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_19
{
    class Find_the_Smallest_Divisor_Given_a_Threshold
    {
        static public int SmallestDivisor(int[] nums, int threshold)
        {
            int lowest = 1;
            int max = nums[nums.Length - 1];
            List<int> mins = new List<int>();
            while (lowest <= max)
            {
                int divided_sum = Calculate(nums, lowest + ((max - lowest) / 2));
                if (divided_sum == threshold)
                {
                    mins.Add(lowest + ((max - lowest) / 2));
                    //lowest--;
                }
                if (divided_sum > threshold)
                {
                    lowest = 1 + lowest + ((max - lowest) / 2);
                }
                else
                {
                    max = -1 + lowest + ((max - lowest) / 2);
                }
            }
            if(mins.Count>0)
                return mins.Min();
            return lowest;
        }

        static public int Calculate(int[] nums, int divisor)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                double f = (double)i / (double)divisor;
                sum += Convert.ToInt32(Math.Ceiling(f));
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SmallestDivisor(new int[] { 1, 2, 5, 9 }, 6));
            Console.WriteLine(SmallestDivisor(new int[] { 2, 3, 5, 7, 11 }, 11));
            Console.WriteLine(SmallestDivisor(new int[] { 19 }, 5));
            Console.WriteLine(SmallestDivisor(new int[] { 59 }, 6));
        }

    }
}
