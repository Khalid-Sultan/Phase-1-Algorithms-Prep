using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Triangle
    {
        public class Solution
        {
            public int MinimumTotal(IList<IList<int>> triangle)
            {
                int result = 0;
                if (triangle.Count == 0)
                {
                    return 0;
                }
                if (triangle.Count == 1)
                {
                    foreach (int i in triangle[0])
                    {
                        if (i < result)
                        {
                            result = i;
                        }
                    }
                    return result;
                }

                for (int i = triangle.Count - 2; i >= 0; i--)
                {
                    for (int j = 0; j < triangle[i].Count; j++)
                    {
                        triangle[i][j] += Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
                    }
                }
                return triangle[0][0];
            }
        }
    }
}
