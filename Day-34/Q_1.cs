using System;
using System.Collections.Generic;
using System.Text;

namespace Day_34
{
    class Q_1
    {
        void check()
        {
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                string input = Console.ReadLine();
                int counter = 0;
                while (true)
                {
                    int first_location = input.IndexOf("10");
                    if (first_location == -1)
                    {
                        break;
                    }
                    int last_location = input.IndexOf("01", first_location);
                    if (first_location < last_location)
                    {
                        input = input.Remove(first_location + 1, last_location - first_location);
                        counter += last_location - first_location;
                        continue;
                    }
                    break;
                }
                Console.WriteLine(counter);
            }

        }
    }
}
