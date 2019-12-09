using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11
{
    class Car_Fleet
    {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            if (position.Length == 0) return 0;
            if (position.Length == 1) return 1;
            SortedDictionary<int, int> keyValuePairs = new SortedDictionary<int, int>();
            for (int i = 0; i < position.Length; i++)
            {
                keyValuePairs[position[i]] = speed[i];
            }
            int counter = 0;
            double[] possibleTimes = new double[position.Length];
            foreach (int key in keyValuePairs.Keys)
            {
                possibleTimes[counter] = CalculateTime(keyValuePairs[key], key, target);
                counter++;
            }
            int fleets = 0;
            for (int i = possibleTimes.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    if (possibleTimes[i] >= possibleTimes[i + 1])
                    {
                        fleets++;
                        break;
                    }

                    else break;
                }
                if (possibleTimes[i] < possibleTimes[i - 1])
                {
                    fleets++;
                    continue;
                }
                else
                {
                    possibleTimes[i - 1] = possibleTimes[i];
                }
            }

            return fleets;
        }
        public double CalculateTime(int speed, int initial, int final)
        {
            return (Convert.ToDouble(final) - Convert.ToDouble(initial)) / Convert.ToDouble(speed);
        }
    }
}
