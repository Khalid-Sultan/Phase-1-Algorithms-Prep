using System;
using System.Collections.Generic;
using System.Text;

namespace Day_38
{
    class Most_Common_Word
    {
        static string MostCommonWord(string paragraph, string[] banned)
        {
            paragraph = paragraph.ToLower();

            // !? ',;.
            paragraph = paragraph.Replace('!', ' ');
            paragraph = paragraph.Replace('?', ' ');
            paragraph = paragraph.Replace('\'', ' ');
            paragraph = paragraph.Replace(',', ' ');
            paragraph = paragraph.Replace(';', ' ');
            paragraph = paragraph.Replace('.', ' ');

            HashSet<string> banned_set = new HashSet<string>();
            foreach(string banned_word in banned)
            {
                banned_set.Add(banned_word);
            }

            string[] word_list = paragraph.Split(' ');
            Dictionary<string, int> pairs = new Dictionary<string, int>();
            foreach(string word in word_list)
            {
                if (!banned_set.Contains(word) && word!="")
                {
                    if (pairs.ContainsKey(word))
                    {
                        pairs[word]++;
                    }
                    else
                    {
                        pairs.Add(word, 1);
                    }
                }
            }

            string frequent_word = "";
            int max_counter = int.MinValue;
            foreach(string word_key in pairs.Keys)
            {
                if (pairs[word_key] > max_counter)
                {
                    frequent_word = word_key;
                    max_counter = pairs[word_key];
                }
            }
            return frequent_word;

        }
        //static void Main(String[] words)
        //{
        //    Console.WriteLine(MostCommonWord("Bob.?hIt, baLl", new string[] { "bob", "hit"}));
        //}
    }
}
