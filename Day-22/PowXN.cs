using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class PowXN
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{MyPow(0, 0)} {MyPow(0, 0) == Math.Pow(0, 0)}");
            Console.WriteLine("");
            Console.WriteLine($"{MyPow(0, 1)} {MyPow(0, 1) == Math.Pow(0, 1)}");
            Console.WriteLine($"{MyPow(0, -1)} {MyPow(0, -1) == Math.Pow(0, -1)}");
            Console.WriteLine("");
            Console.WriteLine($"{MyPow(2, 4)} {MyPow(2, 4) == Math.Pow(2, 4)}");
            Console.WriteLine($"{MyPow(2, -4)} {MyPow(2, -4) == Math.Pow(2, -4)}");
            Console.WriteLine("");
            Console.WriteLine($"{MyPow(2, 5)} {MyPow(2, 5) == Math.Pow(2, 5)}");
            Console.WriteLine($"{MyPow(2, -5)} {MyPow(2, -5) == Math.Pow(2, -5)}");
            Console.WriteLine("");
            Console.WriteLine($"{MyPow(2, 6)} {MyPow(2, 6) == Math.Pow(2, 6)}");
            Console.WriteLine($"{MyPow(2, -6)} {MyPow(2, -6) == Math.Pow(2, -6)}");
            Console.WriteLine("");
            Console.WriteLine($"{MyPow(2, 7)} {MyPow(2, 7) == Math.Pow(2, 7)}");
            Console.WriteLine($"{MyPow(2, -7)} {MyPow(2, -7) == Math.Pow(2, -7)}");
            Console.WriteLine("");
            Console.WriteLine($"{MyPow(2, 9)} {MyPow(2, 9) == Math.Pow(2, 9)}");
            Console.WriteLine($"{MyPow(2, -9)} {MyPow(2, -9) == Math.Pow(2, -9)}");
            Console.WriteLine("");
            Console.WriteLine($"{MyPow(2, 10)} {MyPow(2, 10) == Math.Pow(2, 10)}");
            Console.WriteLine($"{MyPow(2, 10)} {MyPow(2, -10) == Math.Pow(2, -10)}");
        }

        public static double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;
            if (n < 0)
            {
                return 1.00 / CalculatePower(x, -1 * n);
            }
            return CalculatePower(x, n);
        }
        public static double CalculatePower(double x, int n)
        {
            int original_n = n;

            double answer = x * x;
            n -= 2;

            if (n == 2) return answer * answer;
            if (n == 1) return answer * x;
            if (n == 0) return answer;

            double current_min = answer;
            int counter = n/2;
            if (n % 2 == 1) counter++;
            while (n > 1)
            {
                if (counter == 0)
                {
                    current_min = answer;
                    counter = n / 2;
                }
                counter--;
                if (n % 2 == 0)
                {
                    answer *= current_min;
                    n /= 2;
                }
                else
                {
                    answer *= x;
                    n--;
                }
            }
            if (counter > 0) return answer * current_min;
            if(original_n!=2 && original_n!=3 && original_n!=5 && original_n!=7)
                if (original_n%2==0 || original_n%3==0 || original_n%5==0 || original_n%7==0)
                    return answer * x;
            return answer;
        }
    }
}
