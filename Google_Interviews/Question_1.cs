using System;
using System.Collections.Generic;
class Solution
{

    static string solution(string[] A)
    {
        // Your solution goes here.
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        int current_max = 0;
        foreach (string room in A)
        {
            if (room[0] == '-')
            {
                continue;
            }
            if (keyValuePairs.ContainsKey(room.Substring(1)))
            {
                keyValuePairs[room.Substring(1)]++;
            }
            else
            {
                keyValuePairs.Add(room.Substring(1), 1);
            }

            if (keyValuePairs[room.Substring(1)] > current_max)
            {
                current_max = keyValuePairs[room.Substring(1)];
            }
        }
        string possible_max = "9Z";
        foreach (string room in A)
        { 
            if (keyValuePairs[room.Substring(1)] == current_max)
            {
                if (possible_max.CompareTo(room.Substring(1)) > 0)
                {
                    possible_max = room.Substring(1);
                }
            }
        }
        if (current_max > 0)
        {
            return possible_max;
        }
        return null;
    }

    static void Main(String[] args)
    {
        // Read from stdin, solve the problem, and write the answer to stdout.
        //Console.Write(solution(Console.ReadLine().Split(',')));

        //Test Cases
        Console.WriteLine(solution(new string[] { "+1A", "-1A", "+3F", "-3F", "+3F", "+8X" }));
        Console.WriteLine(solution(new string[] { "+1A", "+3F", "+8X", "−1A", "−3F", "−8X" }));
        Console.WriteLine(solution(new string[] { "+0A" }));
        Console.WriteLine(solution(new string[] { "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B" }));
        Console.WriteLine(solution(new string[] { "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B", "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B", "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B", "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B", "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B", "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B", "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B", "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B", "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B", "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B", "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B", "+9Z", "−9Z", "+9Z", "−9Z", "+9Z", "+3B" }));

    }

}