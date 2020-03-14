using System;

class Question_2
{
    static string solution(string T)
    {
        // Your solution goes here.
        //Since we have to return a latest valid time, we can start from the first character till the end.
        char[] T_chars = T.ToCharArray();
        T_chars[0] = T_chars[0] == '?' ? T_chars[1] == '?' ? '2' : T_chars[1] > '3' ? '1' : '2' : T_chars[0];
        T_chars[1] = T_chars[1] == '?' ? T_chars[0] == '2' ? '3' : '9' : T_chars[1];
        T_chars[3] = T_chars[3] == '?' ? '5' : T_chars[3];
        T_chars[4] = T_chars[4] == '?' ? '9' : T_chars[4];
        return new string(T_chars);
    }

    //static void Main(String[] args)
    //{
    //    // Read from stdin, solve the problem, write answer to stdout.
    //    //Console.Write(solution(Console.ReadLine()));

    //    //Test Cases
    //    Console.WriteLine(solution("??:??") == "23:59");
    //    Console.WriteLine(solution("0?:??") == "09:59");
    //    Console.WriteLine(solution("1?:?8") == "19:58");
    //    Console.WriteLine(solution("2?:??") == "23:59");
    //    Console.WriteLine(solution("?2:4?") == "22:49");
    //    Console.WriteLine(solution("?3:4?") == "23:49");
    //    Console.WriteLine(solution("?9:4?") == "19:49");
    //    Console.WriteLine(solution("??:?4")=="23:54");
    //    Console.WriteLine(solution("06:34")=="06:34");
    //}
}
