using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class Fraction_Addition
    {
        public static int gcd(int a, int b)
        {
            if (a < b) return gcd(b, a);
            while (a % b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return b;
        }
        public static int denum(int a, int b)
        {
            return (a * b) / gcd(a, b);
        }


        public static List<int[]> extraction(string expression)
        {
            List<int[]> res = new List<int[]>();
            String[] strings = expression.Split('-');
            for(int i = 0;i< strings.Length; i++)
            {
                if (strings[i].Length == 0) continue;
                String[] strs = strings[i].Split("+");
                for(int j = 0; j<strs.Length; j++)
                {
                    String[] s = strs[j].Split("/");
                    int[] tmp = new int[2];
                    tmp[0] = Convert.ToInt32(s[0]);
                    if(j==0 && i != 0)
                    {
                        tmp[0] *= -1;
                    }
                    tmp[1] = Convert.ToInt32(s[1]);
                    res.Add(tmp);
                }
            }
            return res;
        }
        public static string FractionAddition(string expression)
        {
            List<int[]> ls = extraction(expression);
            int num = ls[0][0];
            int den = ls[0][1];
            for(int i = 1; i<ls.Count; i++)
            {
                int[] v = ls[i];
                int d = denum(den, v[1]);
                num = num * (d / den) + v[0] * (d / v[1]);
                den = d;
            }
            if (num == 0) return "0/1";
            int gcd_val = gcd(Math.Abs(num), den);
            num /= gcd_val;
            den /= gcd_val;
            return num + "/" + den;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FractionAddition("-1/2+1/2+1/3"));
            Console.WriteLine(FractionAddition("5/3+1/3"));
            Console.WriteLine(FractionAddition("1/3-1/2"));
        }



    }
}
