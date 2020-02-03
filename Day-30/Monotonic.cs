using System;

namespace Day_30
{
    class Monotonic
    {

        public static bool IsMonotonic(int[] A)
        {
                bool incrementing = false;
                if(A[0] <= A[A.Length - 1])
                {
                    incrementing = true;
                }
                for(int i = 0; i<A.Length-1; i++)
                {
                    if(incrementing && A[i] > A[i + 1])
                    {
                        return false;
                    }
                    if(!incrementing && A[i] < A[i + 1])
                    {
                        return false;
                    }
                }
                return true;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(IsMonotonic(new int[] { 1, 2, 2, 3 }));
        //    Console.WriteLine(IsMonotonic(new int[] { 6, 5, 4, 4 }));
        //    Console.WriteLine(IsMonotonic(new int[] { 1, 3, 2 }));
        //    Console.WriteLine(IsMonotonic(new int[] { 1, 2, 4, 5 }));
        //    Console.WriteLine(IsMonotonic(new int[] { 1, 2, 0 }));
        //    Console.WriteLine(IsMonotonic(new int[] { 1 }));
        //}
    }
}
