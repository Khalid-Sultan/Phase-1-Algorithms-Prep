using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_26
{
    class Two_City_Scheduling
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            //First Find the distance between the cities as the cost for everyone
            int[][] value_cost = new int[costs.Length][];
            for (int i = 0; i < costs.Length; i++)
            {
                value_cost[i] = new int[]{
                costs[i][0],
                costs[i][1] - costs[i][0]
            };
            }
            //Sort the cost depending on the values given from the closest onwards
            var sorted = value_cost.OrderByDescending(x => x[1]).ToArray();
            int total_cost = 0;
            int mid_point = sorted.Length / 2;
            for (int i = 0; i < sorted.Length; i++)
            {
                //Till N number of persons move in choose the ones with the closest values
                if (i < mid_point) total_cost += sorted[i][0];
                //Finish off with the rest
                else total_cost += sorted[i][0] + sorted[i][1];
            }
            return total_cost;
        }
    }
}
