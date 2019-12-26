using System;
using System.Collections.Generic;
using System.Text;

namespace Day_20
{
    class Temporarily_unavailable
    {
        static void Main(string[] args)
        {
            int test_cases_count = Convert.ToInt32(Console.ReadLine());
            List<List<int>> test_cases = new List<List<int>>();
            for (int i = 0; i < test_cases_count; i++)
            {
                string[] test_case = Console.ReadLine().Split(' ');
                List<int> test_case_list = new List<int>();
                foreach (string s in test_case)
                {
                    test_case_list.Add(Convert.ToInt32(s));
                }
                test_cases.Add(test_case_list);
            }


            foreach (List<int> test_case in test_cases)
            {
                int starting_point = test_case[0];
                int finishing_point = test_case[1];
                int base_station = test_case[2];
                int coverage_radius = test_case[3];

                int min_base_station = base_station - coverage_radius;
                int max_base_station = base_station + coverage_radius;

                if (starting_point < min_base_station && finishing_point > max_base_station)
                {
                    Console.WriteLine((min_base_station - starting_point) + (finishing_point - max_base_station));
                }
                else if (starting_point > max_base_station && finishing_point < min_base_station)
                {
                    Console.WriteLine(Math.Abs((min_base_station - finishing_point) + (starting_point - max_base_station)));
                }

                else if (starting_point >= min_base_station && starting_point <= max_base_station && finishing_point <= max_base_station && finishing_point >= min_base_station)
                {
                    Console.WriteLine(0);
                }

                else if (starting_point >= min_base_station && starting_point <= max_base_station && finishing_point > max_base_station)
                {
                    Console.WriteLine(finishing_point - max_base_station);
                }
                else if (starting_point >= min_base_station && starting_point <= max_base_station && finishing_point < min_base_station)
                {
                    Console.WriteLine(min_base_station - finishing_point);
                }

                else if (finishing_point <= max_base_station && finishing_point >= min_base_station && starting_point < min_base_station)
                {
                    Console.WriteLine(min_base_station - starting_point);
                }
                else if (finishing_point <= max_base_station && finishing_point >= min_base_station && starting_point > max_base_station)
                {
                    Console.WriteLine(starting_point - max_base_station);
                }

                else if (starting_point > max_base_station && finishing_point > max_base_station)
                {
                    if (finishing_point >= starting_point)
                    {
                        Console.WriteLine(finishing_point - starting_point);
                    }
                    else
                    {
                        Console.WriteLine(starting_point - finishing_point);
                    }
                }
                else if (starting_point < min_base_station && finishing_point < min_base_station)
                {
                    if (finishing_point >= starting_point)
                    {
                        Console.WriteLine(finishing_point - starting_point);
                    }
                    else
                    {
                        Console.WriteLine(starting_point - finishing_point);
                    }

                }


            }



        }
    }
}
