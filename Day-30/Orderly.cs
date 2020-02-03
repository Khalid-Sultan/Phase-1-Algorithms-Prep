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
            }
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
