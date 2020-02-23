using System;
using System.Collections.Generic;
using System.Text;

namespace Day_28
{
    class ValidateStack
    {
        static bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> result = new Stack<int>();
            int j = 0;
            foreach (int i in pushed)
            {
                result.Push(i);
                while (result.Count > 0 && j < pushed.Length && result.Peek() == popped[j])
                {
                    result.Pop();
                    j++;
                }
            }
            return j == pushed.Length;
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
