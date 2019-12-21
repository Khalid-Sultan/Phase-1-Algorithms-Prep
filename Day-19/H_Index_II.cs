using System;
using System.Collections.Generic;
using System.Text;

namespace Day_19
{
    class H_Index_II
    {
        public int HIndex(int[] citations)
        {
            //Iterative Approach
            // int i = 0;
            // int n = citations.Length;
            // while (i < n && citations[i] < (n - i)) i++;
            // return n - i;
            //Binary Search Approach
            int lowest = 0;
            int max = citations.Length - 1;
            if (citations.Length == 0 || citations == null) return 0;
            if (citations.Length == 1 && citations[0] == 0) return 0;
            if (citations.Length == 1) return 1;

            while (lowest <= max)
            {
                if (citations[lowest + ((max - lowest) / 2)] == citations.Length - (lowest + ((max - lowest) / 2)))
                {
                    return citations[lowest + ((max - lowest) / 2)];
                }
                else if (citations[lowest + ((max - lowest) / 2)] > citations.Length - (lowest + ((max - lowest) / 2)))
                {
                    max = -1 + lowest + ((max - lowest) / 2);
                }
                else
                {
                    lowest = 1 + lowest + ((max - lowest) / 2);
                }
            }
            return citations.Length - (max + 1);
        }
    }
}
