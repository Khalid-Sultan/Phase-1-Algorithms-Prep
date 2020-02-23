using System;
using System.Collections.Generic;
using System.Text;

namespace Day_28
{
    class BagOfTokens
    {
        public static int BagOfTokensScore(int[] tokens, int P)
        {
            int points = 0;
            int max_points = 0;
            Array.Sort(tokens);

            int start = 0;
            int end = tokens.Length - 1;

            while (start <= end)
            {
                if (P >= tokens[start])
                {
                    points++;
                    P -= tokens[start++];
                    max_points = Math.Max(max_points, points);
                }
                else if (points > 0)
                {
                    points--;
                    P += tokens[end--];
                }
                else
                {
                    return max_points;
                }
            }

            return max_points;
        }

        static void Main(String[] args)
        {
            Console.WriteLine(BagOfTokensScore(new int[] { 100 }, 50));
            Console.WriteLine(BagOfTokensScore(new int[] { 100, 200 }, 150));
            Console.WriteLine(BagOfTokensScore(new int[] { 100, 200, 300, 400 }, 200));
        }
    }
}
