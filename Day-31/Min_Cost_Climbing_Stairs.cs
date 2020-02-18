using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Min_Cost_Climbing_Stairs
    {
        public class Solution
        {
            public int MinCostClimbingStairs(int[] cost)
            {
                int[] saved = new int[cost.Length];
                saved[0] = cost[0];
                saved[1] = cost[1];

                for (int i = 2; i < cost.Length; i++)
                {
                    saved[i] = Math.Min(saved[i - 1] + cost[i], saved[i - 2] + cost[i]);
                }
                return Math.Min(saved[cost.Length - 1], saved[cost.Length - 2]);
            }
        }
    }
}
