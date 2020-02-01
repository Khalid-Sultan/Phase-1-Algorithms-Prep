using System;
using System.Collections.Generic;
using System.Text;

namespace Day_28
{
    class ValidateStack
    {
        public static bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Dictionary<int, int[]> pushed_pairs = new Dictionary<int, int[]>();
            pushed_pairs.Add(pushed[0], new int[] { 0, 1 });
            for (int i = 1; i < pushed.Length; i++)
            {
                pushed_pairs.Add(pushed[i], new int[] { i-1, i+1});
            }

            int[] prev = new int[] { 0, 0};
            foreach(int i in popped) {
                prev = pushed_pairs[i];
                pushed_pairs.Remove(i);
                if(prev[0]!=i && prev[1] != i)
                {
                    return false;
                }
            }
            return true;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 }));
        //    Console.WriteLine(ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 3, 5, 1, 2  }));
        //    Console.WriteLine(ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 3, 5, 2, 1 }));
        //    Console.WriteLine(ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 }));
        //    Console.WriteLine(ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }));
        //    Console.WriteLine(ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 5, 1, 4 }));
        //}


    }
}
