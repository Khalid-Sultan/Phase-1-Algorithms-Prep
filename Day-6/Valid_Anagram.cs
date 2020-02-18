using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            char[] characters = s.ToCharArray();
            char[] characters_2 = t.ToCharArray();
            int[] counter = new int[26];
            int length = s.Length;
            if (s.Length != t.Length) return false;
            for (int i = 0; i < 26; i++)
            {
                counter[i] = 0;
            }
            for (int i = 0; i < length; i++)
            {
                int value = characters[i] - 97;
                counter[value] += 1;
                int value_2 = characters_2[i] - 97;
                counter[value_2] -= 1;
            }
            foreach (int count in counter)
            {
                if (count != 0) return false;
            }
            return true;
        }
    }
}
