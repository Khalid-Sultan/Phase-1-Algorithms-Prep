using System;
using System.Collections.Generic;
using System.Text;

namespace Day_29
{
    class EquivalentDominoes
    {
        public static int NumEquivDominoPairs(int[][] dominoes)
        {
            int counter = 0;
            int[] ones = new int[10];
            for(int i =0; i<ones.Length; i++)
            {
                ones[i] = 0;
            }
            int[][] array = new int[10][];
            for(int i = 0; i<array.Length; i++)
            {
                array[i] = new int[10];
                Array.Copy(ones,0,array[i],0,10);
            }
            foreach(int[] domino in dominoes)
            {
                array[domino[0]][domino[1]]++;
                array[domino[1]][domino[0]]++;
            }
            for(int i = 0; i<dominoes.Length; i++)
            {
                int[] current_domino = dominoes[i];
                if(array[current_domino[0]][current_domino[1]]== array[current_domino[1]][current_domino[0]] && array[current_domino[0]][current_domino[1]]>1)
                {
                    counter++;
                    array[current_domino[0]][current_domino[1]]--;
                    array[current_domino[1]][current_domino[0]]--;
                }
            }
            return counter;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(NumEquivDominoPairs(new int[][] {
        //    new int[]{5, 6 }
        //    }));
        //    Console.WriteLine(NumEquivDominoPairs(new int[][]
        //    {
        //        new int[]{1, 2 },
        //        new int[]{1, 2 },
        //        new int[]{1, 1 },
        //        new int[]{1, 2 },
        //        new int[]{2, 2 }
        //    }));
        //}


    }
}
