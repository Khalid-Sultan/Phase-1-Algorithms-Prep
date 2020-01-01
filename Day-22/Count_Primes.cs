using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class Count_Primes
    {
        public int CountPrimes(int n)
        {
            bool[] isPrime = new bool[n];
            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i < n; i++)
            {
                if (!isPrime[i]) continue;
                for (int j = i * i; j < n; j += i)
                {
                    isPrime[j] = false;
                }
            }
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i]) count++;
            }
            return count;
        }
    }
}
