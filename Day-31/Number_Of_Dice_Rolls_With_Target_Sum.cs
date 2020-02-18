using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Number_Of_Dice_Rolls_With_Target_Sum
    {
        public class Solution
        {
            public int NumRollsToTarget(int d, int f, int target)
            {
                int[][] dp_matrix = new int[d + 1][];
                for (int i = 0; i < d + 1; i++)
                {
                    dp_matrix[i] = new int[Math.Max(target, f) + 1];
                }
                for (int i = 0; i < dp_matrix.Length; i++)
                {
                    for (int j = 0; j < dp_matrix[i].Length; j++)
                    {
                        dp_matrix[i][j] = -1;
                    }
                }
                return solve(d, f, target, dp_matrix);
            }

            public int solve(int d, int f, int target, int[][] dp_matrix)
            {
                if (dp_matrix[d][target] != -1)
                {
                    return dp_matrix[d][target];
                }

                if (target == 0)
                {
                    return 0;
                }
                if (target > f && d == 1)
                {
                    return 0;
                }
                if (target <= f && d == 1)
                {
                    return 1;
                }

                int total = 0;
                for (int i = 1; i <= f; i++)
                {
                    int left_side = solve(1, f, i, dp_matrix);
                    int right_side = 0;
                    if (target - i >= 0)
                    {
                        right_side = solve(d - 1, f, target - i, dp_matrix);
                    }
                    int temp = (left_side * right_side) % Convert.ToInt32(Math.Pow(10, 9) + 7);
                    total += temp;
                    total %= Convert.ToInt32(Math.Pow(10, 9) + 7);
                }
                dp_matrix[d][target] = total;
                return total;
            }
        }
    }
}
