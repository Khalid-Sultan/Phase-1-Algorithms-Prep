using System;
using System.Collections.Generic;

namespace Day_23
{
    class Fadi_And_LCM
    {
        static Int64 gcd(Int64 a, Int64 b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }
        static Int64 lcm(Int64 a, Int64 b)
        {
            return (a * b) / gcd(a, b);
        }
        public static List<Int64> SieveOfEratosthenes(Int64 n)
        {
            Dictionary<Int64, Int64> keyValuePairs = new Dictionary<Int64, Int64>();

            for (Int64 p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed, 
                // then it is a prime 
                if (!keyValuePairs.ContainsKey(p))
                {
                    //// Update all multiples of p 
                    keyValuePairs.Add(p, 1);
                }
            }
            List<Int64> primes = new List<Int64>();
            foreach (Int64 key in keyValuePairs.Keys) primes.Add(key);
            return primes;
        }

        static void Find_Them()
        {
            Int64 X = Convert.ToInt64(Console.ReadLine());
            if (X == 1)
            {
                Console.WriteLine("1 1");
                return;
            }
            SortedDictionary<Int64, Int64> keyValuePairs = new SortedDictionary<Int64, Int64>();
            Int64 last_added = 1;
            keyValuePairs.Add(1, X);
            List<Int64> primes = SieveOfEratosthenes(X);
            foreach (Int64 i in primes)
            {
                if (X % i == 0)
                {
                    if (keyValuePairs.ContainsKey(i) || keyValuePairs.ContainsKey(X / i))
                        continue;
                    else
                    {
                        if (lcm(i, X / i) == X)
                        {
                            keyValuePairs.Add(i, X / i);
                            last_added = i;
                        }
                    }
                }
            }
            Console.WriteLine($"{last_added} {keyValuePairs[last_added]}");
        }
    }
}
