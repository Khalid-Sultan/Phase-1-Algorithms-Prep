using System;
using System.Collections.Generic;
using System.Text;

namespace Day_28
{
    class BagOfTokens
    {
        public static int BagOfTokensScore(int[] tokens, int P)
        {
            if (tokens.Length == 0) return 0;
            int points = 0;
            Array.Sort(tokens);

            List<int> tokenList = new List<int>(tokens);
            List<int> pointsTally = new List<int>();

            int counter = 0;
            while(tokenList.Count>0)
            {
                if(tokenList.Contains(P))
                {
                    tokenList.RemoveAt(tokenList.IndexOf(P));
                    P -= P;
                    points++;
                    counter++;
                }
                else
                {
                    if (points >= 1 && tokenList[0]>P)
                    {
                        points--;
                        P += tokenList[tokenList.Count - 1];
                        tokenList.RemoveAt(tokenList.Count - 1);
                        counter++;
                    }
                    else
                    {
                        if (P >= tokenList[0])
                        {
                            P -= tokenList[0];
                            points++;
                            tokenList.RemoveAt(0);
                            counter++;
                        }
                    }
                }
                pointsTally.Add(points);
                if (counter == 0)
                {
                    break;
                }
                counter = 0;
            }
            pointsTally.Sort();
            return pointsTally[pointsTally.Count-1];
        }

        static void Main(String[] args)
        {
            Console.WriteLine(BagOfTokensScore(new int[] { 100 }, 50));
            Console.WriteLine(BagOfTokensScore(new int[] { 100, 200 }, 150));
            Console.WriteLine(BagOfTokensScore(new int[] { 100, 200, 300, 400 }, 200));
        }
    }
}
