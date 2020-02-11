using System;
using System.Collections.Generic;
using System.Text;

namespace Day_33
{
    class Number_Of_Lines_To_Write_String
    {
        static int[] NumberOfLines(int[] widths, string S)
        {
            int[] result = new int[2];
            int current_row_sum = 0;
            int current_row_counter = 1;
            foreach(char c in S)
            {
                int current_width = widths[c - 'a'];
                if (current_row_sum + current_width <=100)
                {
                    current_row_sum += current_width;
                }
                else
                {
                    current_row_sum = current_width;
                    current_row_counter++;
                }
            }
            result[0] = current_row_counter;
            result[1] = current_row_sum;
            return result;
        }

        //static void Main(string[] args)
        //{
        //    int[] result = NumberOfLines(new int[] { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, "b");
        //    Console.WriteLine($"{result[0]}, {result[1]}");
        //}
    }
}
