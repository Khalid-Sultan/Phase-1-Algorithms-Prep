using System;
using System.Collections.Generic;
using System.Text;

namespace Day_30
{
    class Orderly
    {
        public static string OrderlyQueue(string S, int K)
        {
            if (K == S.Length || K > 1)
            {
                char[] vs = S.ToCharArray();
                Array.Sort(vs);
                return new string(vs);
            }
            else
            {
                string result = S;
                for(int i = 0; i<S.Length; i++)
                {
                    if(new string($"{S.Substring(i)}{S.Substring(0, i)}").CompareTo(result)<0)
                    {
                        result = $"{S.Substring(i)}{S.Substring(0, i)}";
                    }
                }
                return result;
                //char[] original = S.ToCharArray();

                //StringBuilder firstHalf = new StringBuilder().Append(original, 0, K);
                //StringBuilder secondHalf = new StringBuilder().Append(original, K, S.Length - K);

                //int max_first = maxIndex(char_array: firstHalf.ToString());
                //int min_second = minIndex(char_array: secondHalf.ToString());

                //if (firstHalf[max_first]<=secondHalf[min_second])
                //{
                //    return S;
                //}
                //else
                //{
                //    char i = firstHalf[max_first];
                //    firstHalf.Remove(max_first, 1);
                //    secondHalf.Append(i);
                //    return OrderlyQueue(firstHalf.Append(secondHalf.ToString()).ToString(), K);
                //}
            }
        }

        public static int minIndex(string char_array)
        {
            int initial = 0;
            for (int i = 0; i < char_array.Length; i++)
            {
                if (char_array[i] < char_array[initial])
                {
                    initial = i;
                }
            }
            return initial;
        }

        public static int maxIndex(string char_array)
        {
            int initial = 0;
            for (int i = 0; i < char_array.Length; i++)
            {
                if (char_array[i] > char_array[initial])
                {
                    initial = i;
                }
            }
            return initial;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(OrderlyQueue("c", 1));
            Console.WriteLine(OrderlyQueue("cb", 1));
            Console.WriteLine(OrderlyQueue("cba", 1));
            Console.WriteLine(OrderlyQueue("hgm", 1));
            Console.WriteLine(OrderlyQueue("hgm", 2));
            Console.WriteLine(OrderlyQueue("gxzv", 4));
            Console.WriteLine(OrderlyQueue("kikc", 3));
            Console.WriteLine(OrderlyQueue("baaca", 3));
            Console.WriteLine(OrderlyQueue("baacaa", 3));
            Console.WriteLine(OrderlyQueue("zyxwvutsrqponmlkjihgfedcba", 25));

            Console.WriteLine(OrderlyQueue("xitavoyjqiupzadbdyymyvuteolyeerecnuptghlzsynozeuuvteryojyokpufanyrqqmtgxhyycltlnusyeyyqygwupcaagtkuq", 1));
        }
    }
}
