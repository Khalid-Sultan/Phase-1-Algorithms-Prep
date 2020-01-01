using System;
using System.Collections.Generic;
using System.Text;

namespace Day_21
{
    class New_Year_Garlands
    {
        static void Main(string[] args)
        {
            int test_cases = Convert.ToInt32(Console.ReadLine());
            List<List<int>> color_test_cases = new List<List<int>>();
            for (int i = 0; i < test_cases; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                int red = Convert.ToInt32(values[0]);
                int green = Convert.ToInt32(values[1]);
                int blue = Convert.ToInt32(values[2]);

                List<int> colors = new List<int>() { red, green, blue };
                color_test_cases.Add(colors);
            }
            foreach (List<int> colors in color_test_cases)
            {
                //int prev = 0;
                Dictionary<int, int> dict = new Dictionary<int, int>();

                int max_index = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (colors[i] > colors[max_index]) max_index = i;
                }
                int residual_sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (i != max_index) residual_sum += colors[i];
                }
                if (residual_sum + 1 < colors[max_index])
                {
                    Console.WriteLine("No");
                    continue;
                }
                Console.WriteLine("Yes");
                continue;
            }

        }
    }
}
