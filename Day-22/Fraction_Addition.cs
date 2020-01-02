using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class Fraction_Addition
    {
        public static string FractionAddition(string expression)
        {
            string[] fractions = expression.Split('/');
            List<string> fracts = new List<string>();

            StringBuilder result = new StringBuilder();
            return result.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"{FractionAddition("-1/2+1/2")}");
            Console.WriteLine($"{FractionAddition("-1/2+1/2+1/3")}");
            Console.WriteLine($"{FractionAddition("1/3-1/2")}");
            Console.WriteLine($"{FractionAddition("5/3+1/3")}");
        }



    }
}
