using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace SH1
{
    class _2D_Array
    {
        static int calculateSum(int[][] arr, int row, int col)
        {
            return
                arr[row][col] +
                arr[row][col + 1] +
                arr[row][col + 2] +
                arr[row + 2][col] +
                arr[row + 2][col + 1] +
                arr[row + 2][col + 2] +
                arr[row + 1][col + 1];
        }
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            SortedSet<int> sets = new SortedSet<int>();
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr[0].Length - 2; j++)
                {
                    sets.Add(calculateSum(arr, i, j));
                }
            }
            return sets.Max();
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}