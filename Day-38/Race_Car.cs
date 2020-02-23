using System;
using System.Collections.Generic;
using System.Text;

namespace Day_38
{
    class Race_Car
    {
        static int Racecar(int target)
        {
            List<string> result = new List<string>();
            
            int cur_speed = 1;
            int cur_pos = 0;

            while (cur_pos != target)
            {
                if (cur_pos < target)
                {
                    if(cur_speed>0 && cur_pos + cur_speed <= target)
                    {
                        cur_pos += cur_speed;
                        cur_speed *= 2;
                        result.Add("A");
                    }
                    else
                    {
                        if (cur_speed == -1 &&cur_pos+cur_speed<=target)
                        {
                            cur_pos += cur_speed;
                            cur_speed *= 2;
                            result.Add("A");
                        }
                        else if (cur_speed < -1)
                        {
                            cur_speed = 1;
                            result.Add("R");
                        }
                        else if (cur_pos + Math.Ceiling(Convert.ToDouble(cur_speed)/2d) > target)
                        {
                            cur_speed = -1;
                            result.Add("R");
                            //cur_speed = 1;
                            //result.Add("R");
                        }
                        else
                        {
                            cur_pos += cur_speed;
                            cur_speed *= 2;
                            result.Add("A");
                            cur_speed = -1;
                            result.Add("R");
                        }
                    }
                }
                else
                {
                    if (cur_speed==-1)
                    {
                        cur_pos += cur_speed;
                        cur_speed *= 2;
                        result.Add("A");
                    }
                    else
                    {
                        cur_speed = -1;
                        result.Add("R");
                    }
                }
            }
            return result.Count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Racecar(4));
        }
    }
}
