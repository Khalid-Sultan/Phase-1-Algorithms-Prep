using System;
using System.Collections.Generic;
using System.Text;

namespace Day_36
{
    class Shifting_Letters
    {
        static string ShiftingLetters(string S, int[] shifts)
        {
            char[] characters = S.ToCharArray();
            long[] shifts_long = new long[shifts.Length];
            for(int i = 0; i<shifts_long.Length; i++)
            {
                shifts_long[i] = shifts[i];
            }

            for (int i = shifts_long.Length - 2; i >= 0; i--)
            {
                shifts_long[i] += shifts_long[i + 1];
            }

            for (int i = 0; i < characters.Length; i++)
            {
                long currentChar = characters[i] - 'a';
                currentChar += shifts_long[i];
                currentChar %= 26;
                characters[i] = (char)(currentChar + 'a');
            }

            return new string(characters);
        }
        //static void Main(String[] args)
        //{
        //    Console.WriteLine(ShiftingLetters("abc", new int[] { 3, 5, 9 }));
        //    Console.WriteLine(ShiftingLetters("a", new int[] { 0 }));
        //    Console.WriteLine(ShiftingLetters("mkgfzkkuxownxvfvxasy", new int[] { 505870226, 437526072, 266740649, 224336793, 532917782, 311122363, 567754492, 595798950, 81520022, 684110326, 137742843, 275267355, 856903962, 148291585, 919054234, 467541837, 622939912, 116899933, 983296461, 536563513 }));
        //}
    }
}
