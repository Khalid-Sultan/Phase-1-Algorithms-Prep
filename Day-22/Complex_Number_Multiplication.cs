using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class Complex_Number_Multiplication
    {
        public string ComplexNumberMultiply(string a, string b)
        {
            string[] a_split = a.Split("+");
            string[] b_split = b.Split("+");


            // (a+bi) * (c+di)
            // ac - bd + (bc+ad)i

            int a_1 = Convert.ToInt32(a_split[0]);
            int b_1 = Convert.ToInt32(b_split[0]);

            int a_2 = 0;
            int b_2 = 0;

            if (a_split[1][0] == '-')
            {
                a_2 = -1 * Convert.ToInt32(a_split[1].Split("-")[1].Split("i")[0]);
            }
            else
            {
                a_2 = Convert.ToInt32(a_split[1].Split("i")[0]);
            }
            if (b_split[1][0] == '-')
            {
                b_2 = -1 * Convert.ToInt32(b_split[1].Split("-")[1].Split("i")[0]);
            }
            else
            {
                b_2 = Convert.ToInt32(b_split[1].Split("i")[0]);
            }

            return string.Format("{0}+{1}i", (b_1 * a_1) - (a_2 * b_2), (b_1 * a_2) + (b_2 * a_1));

        }
    }
}
