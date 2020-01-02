using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class PowXN
    {
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
        public static double CalculatePower(double a, int b)
        {
            double y = 1;

            while (true)
            {
                if ((b & 1) != 0) y = a * y;
                b /= 2;
                if (b == 0) return y;
                a *= a;
            }
        }

    }
}
