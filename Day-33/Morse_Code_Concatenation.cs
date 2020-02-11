using System;
using System.Collections.Generic;
using System.Text;

namespace Day_33
{
    class Morse_Code_Concatenation
    {
        static int UniqueMorseRepresentations(string[] words)
        {
            string[] keys = new string[] {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};
            Dictionary<string, int> pairs = new Dictionary<string, int>();
            foreach(string word in words)
            {
                StringBuilder s = new StringBuilder();
                foreach(char c in word)
                {
                    s.Append(keys[c - 'a']);
                }
                if (pairs.ContainsKey(s.ToString()))
                {
                    pairs[s.ToString()]++;
                }
                else
                {
                    pairs.Add(s.ToString(), 1);
                }
            }
            return pairs.Count;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(UniqueMorseRepresentations(new string[] { "gin", "zen", "gig", "msg" }));
        //}
    }
}
