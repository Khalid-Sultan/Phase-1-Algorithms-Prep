using System;
using System.Collections.Generic;
using System.Text;

namespace Day_32_2
{
    class Jump_Game_III
    {
        public bool CanReach(int[] arr, int start)
        {
            int[] possible_moves = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                possible_moves[i] = -1;
            }

            possible_moves[start] = JumpUpAndAway(arr, possible_moves, start);
            Array.Sort(possible_moves);
            return possible_moves[arr.Length - 1] == 2 ? true : false;
        }

        public int JumpUpAndAway(int[] arr, int[] possible_moves, int start)
        {
            try
            {
                if (arr[start] == 0)
                {
                    return 2;
                }
                if (start < 0 || start >= arr.Length)
                {
                    return 1;
                }
                if (start >= 0 && start <= arr.Length - 1 && start + arr[start] < arr.Length)
                {
                    if (possible_moves[start + arr[start]] == -1)
                    {
                        possible_moves[start + arr[start]] = JumpUpAndAway(arr, possible_moves, start + arr[start]);
                    }
                }
                if (start >= 0 && start <= arr.Length - 1 && start - arr[start] >= 0)
                {
                    if (possible_moves[start - arr[start]] == -1)
                    {
                        possible_moves[start - arr[start]] = JumpUpAndAway(arr, possible_moves, start - arr[start]);
                    }
                }

            }
            catch
            {
                return 1;
            }
            return 1;
        }
    }
}
