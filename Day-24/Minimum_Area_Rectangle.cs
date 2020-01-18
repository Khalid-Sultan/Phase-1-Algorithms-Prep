using System;
using System.Collections.Generic;
using System.Text;

namespace Day_24
{
    class Minimum_Area_Rectangle
    {
        public int MinAreaRect(int[][] points)
        {
            Dictionary<int, List<int>> row_points = new Dictionary<int, List<int>>();

            //First Collect the first row
            foreach(int[] i in points)
            {
                if (row_points.ContainsKey(i[1])) row_points[i[1]].Add(i[0]);
                else row_points.Add(i[1], new List<int>(i[0]));
            }

            //Left_Bottom
            //Right_Bottom
            //Left_Top
            //Right_Top


            return 0;
        }

    }
}
