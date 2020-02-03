using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Question_8_Balanced_String_Split
    {
        public int BalancedStringSplit(string s)
        {
            int counter = 0;
            int[] vals = new int[2];
            vals[0] = 0;
            vals[1] = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                {
                    vals[1]++;
                }
                if (s[i] == 'L')
                {
                    vals[0]++;
                }
                if (vals[0] == vals[1])
                {
                    counter++;
                    vals[0] = 0;
                    vals[1] = 0;
                }
            }
            return counter;
        }
    }
}
