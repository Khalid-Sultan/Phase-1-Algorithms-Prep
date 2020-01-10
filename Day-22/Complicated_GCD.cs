using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Day_22
{
    class Complicated_GCD
    {
        static void is_complicated()
        {
            string[] s = Console.ReadLine().Split(' ');
            BigInteger i = BigInteger.Parse(s[0]);
            BigInteger j = BigInteger.Parse(s[1]);
            if (i == j) Console.WriteLine(i);
            else Console.WriteLine(1);
        }

    }
}
