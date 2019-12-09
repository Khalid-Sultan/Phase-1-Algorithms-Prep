using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12
{
    class Class1
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vs = input.Split(' ');
            int[] values = new int[4];
            int total = 0;
            int index = 0;
            int max_index = 0;
            foreach (string c in vs)
            {
                total += Convert.ToInt32(c);
                values[index] = Convert.ToInt32(c);
                if (Convert.ToInt32(c) > max_index) max_index = index;
                index++;
            }
            int added = 0;
            int[] resultArray = new int[total];

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (i == 0)
                {
                    if (values[0] > 0)
                    {
                        resultArray[0] = 0;
                        added++;
                        values[0]--;
                    }
                    else if (values[1] > 0)
                    {
                        resultArray[0] = 1;
                        added++;
                        values[1]--;
                    }
                    else if (values[2] > 0)
                    {
                        resultArray[0] = 2;
                        added++;
                        values[2]--;
                    }
                    else if (values[3] > 0)
                    {
                        resultArray[0] = 3;
                        added++;
                        values[3]--;
                    }
                }
                else
                {
                    if (resultArray[i - 1] == 0 && values[1] > 0)
                    {
                        resultArray[i] = 1;
                        added++;
                        values[1]--;
                    }
                    else if (resultArray[i - 1] == 1 && values[0] > 0)
                    {
                        resultArray[i] = 0;
                        added++;
                        values[0]--;
                    }
                    else if (resultArray[i - 1] == 1 && values[2] > 0)
                    {
                        resultArray[i] = 2;
                        added++;
                        values[2]--;
                    }
                    else if (resultArray[i - 1] == 2 && values[1] > 0)
                    {
                        resultArray[i] = 1;
                        added++;
                        values[1]--;
                    }
                    else if (resultArray[i - 1] == 2 && values[3] > 0)
                    {
                        resultArray[i] = 3;
                        added++;
                        values[3]--;
                    }
                    else if (resultArray[i - 1] == 3 && values[2] > 0)
                    {
                        resultArray[i] = 2;
                        added++;
                        values[2]--;
                    }
                }
            }
            if (values[0] > 0 && resultArray[added - 1] - 0 == 1)
            {
                resultArray[added] = 0;
                added++;
            }
            if (values[1] > 0 && resultArray[added - 1] - 1 == 1)
            {
                resultArray[added] = 1;
                added++;
            }
            if (values[2] > 0 && resultArray[added - 1] - 2 == 1)
            {
                resultArray[added] = 2;
                added++;
            }
            if (values[3] > 0 && resultArray[added - 1] - 3 == 1)
            {
                resultArray[added] = 3;
                added++;
            }
            if (added == total)
            {
                Console.WriteLine("YES");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    if (i == resultArray.Length - 1)
                    {
                        Console.WriteLine($"{resultArray[i]}");
                    }
                    else
                        Console.Write($"{resultArray[i]} ");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
