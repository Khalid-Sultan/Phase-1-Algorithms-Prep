using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class Fraction
    {
        // Recursive function to 
        // return gcd of a and b 
        static int __gcd(int a, int b)
        {
            // Everything divides 0 
            if (a == 0 || b == 0)
                return 0;

            // base case 
            if (a == b)
                return a;

            // a is greater 
            if (a > b)
                return __gcd(a - b, b);

            return __gcd(a, b - a);
        }

        // function to check and print if 
        // two numbers are co-prime or not 
        static bool coprime(int a, int b)
        {

            if (__gcd(a, b) == 1)
                return true;
            return false;
        }

        static void FindFraction()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = n/2;
            while (i > 0)
            {
                if (coprime(i, n - i))
                {
                    Console.WriteLine($"{i} {n - i}");
                    break;
                }
                i--;
            }
        }

    }
}
