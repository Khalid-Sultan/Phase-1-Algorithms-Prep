using System;
using System.Collections.Generic;

namespace Day_17
{
    class Three_Friends
    {
        //static void Main(string[] args)
        //{
        //    int test_cases = Convert.ToInt32(Console.ReadLine());
        //    List<int[]> values = new List<int[]>();
        //    for (int i = 0; i < test_cases; i++)
        //    {
        //        string value = Console.ReadLine();
        //        string[] split = value.Split(' ');
        //        values.Add(new int[] { Convert.ToInt32(split[0]), Convert.ToInt32(split[1]), Convert.ToInt32(split[2]) });
        //    }

        //    foreach (int[] i in values)
        //    {
        //        Console.WriteLine(CalculateMinPairwise(i));
        //    }
        //}
        static int CalculateMinPairwise(int[] i)
        {
            int a = i[0];
            int b = i[1];
            int c = i[2];

            if (a == b && b == c) return 0;

            List<int> possibleValuesOfA = new List<int>();
            List<int> possibleValuesOfB = new List<int>();
            List<int> possibleValuesOfC = new List<int>();

            possibleValuesOfA.Add(a - 1);
            possibleValuesOfA.Add(a);
            possibleValuesOfA.Add(a + 1);

            possibleValuesOfB.Add(b - 1);
            possibleValuesOfB.Add(b);
            possibleValuesOfB.Add(b + 1);

            possibleValuesOfC.Add(c - 1);
            possibleValuesOfC.Add(c);
            possibleValuesOfC.Add(c + 1);

            SortedSet<int> pairwises = new SortedSet<int>();
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        pairwises.Add(
                            Math.Abs(possibleValuesOfA[j] - possibleValuesOfB[k]) +
                            Math.Abs(possibleValuesOfA[j] - possibleValuesOfC[l]) +
                            Math.Abs(possibleValuesOfB[k] - possibleValuesOfC[l])
                        );
                    }

                }

            }
            if (pairwises.Count < 0) return 0;
            return pairwises.Min;
        }
    }
}
