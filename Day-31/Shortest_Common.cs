using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Shortest_Common
    {
        public string ShortestCommonSupersequence(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                string temp = str1;
                str1 = str2;
                str2 = temp;
            }

            for(int i = 0; i<str1.Length; i++)
            {

            }
        }

        static void Main(string[] args)
        {
        }

    }
}
