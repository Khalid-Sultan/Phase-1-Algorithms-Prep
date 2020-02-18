using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Divisor_Game
    {
        public class Solution
        {
            public bool DivisorGame(int N)
            {
                bool alice_wins = true;
                while (N > 0)
                {
                    N -= 1;
                    if (alice_wins) alice_wins = false;
                    else alice_wins = true;
                }
                return alice_wins;
            }
        }
    }
}
