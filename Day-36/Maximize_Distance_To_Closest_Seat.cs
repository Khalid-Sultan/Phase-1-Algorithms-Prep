using System;
using System.Collections.Generic;
using System.Text;

namespace Day_36
{
    class Maximize_Distance_To_Closest_Seat
    {
        static int MaxDistToClosest(int[] seats)
        {
            int distance = 0;
            int last_location = 0;
            if (seats[0] == 0)
            {
                int temp_distance = 0;
                for (int i = 0; i < seats.Length; i++)
                {
                    if (seats[i] == 1)
                    {
                        break;
                    }
                    temp_distance++;
                    last_location++;
                }
                if (temp_distance > distance)
                {
                    distance = temp_distance;
                }
            }
            if (seats[seats.Length - 1] == 0)
            {
                int temp_distance = 0;
                for (int i = 0; i < seats.Length; i++)
                {
                    if (seats[i] == 1)
                    {
                        temp_distance = 0;
                        continue;
                    }
                    temp_distance++;
                }
                if (temp_distance > distance)
                {
                    distance = temp_distance;
                }
            }
            int temp = 0;
            for (int i = last_location; i < seats.Length; i++)
            {
                if (seats[i] == 1)
                {
                    if (temp == 1 && temp > distance)
                    {
                        distance = 1;
                    }
                    else if (Math.Ceiling(Convert.ToDouble(temp) / 2) > distance)
                    {
                        distance = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(temp) / 2));
                    }
                    temp = 0;
                    continue;
                }
                temp++;
            }
            return distance;
        }
        //static void Main(String[] args)
        //{
        //    Console.WriteLine(MaxDistToClosest(new int[] { 1, 0, 0, 0, 1, 0, 1 }));
        //    Console.WriteLine(MaxDistToClosest(new int[] { 0, 0, 0, 1, 0, 0, 0 }));
        //    Console.WriteLine(MaxDistToClosest(new int[] { 1, 0 }));
        //    Console.WriteLine(MaxDistToClosest(new int[] { 0, 1 }));
        //    Console.WriteLine(MaxDistToClosest(new int[] { 1, 1, 0, 0, 0, 1, 0 }));
        //    Console.WriteLine(MaxDistToClosest(new int[] { 1, 0, 0, 0, 1, 0, 1, 0, 0, 0 }));
        //    Console.WriteLine(MaxDistToClosest(new int[] { 1, 0, 0, 0, 1, 0, 1 }));
        //}

    }
}
