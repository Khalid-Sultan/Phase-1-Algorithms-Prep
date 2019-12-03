using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_6
{
    class Matrix_Cells_in_Distance_Order
    {
        class Point : IComparable<Point>
        {
            public readonly int x;
            public readonly int y;
            public static Point origin;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int CompareTo(Point other)
            {
                return (Math.Abs(x - origin.x) + Math.Abs(y - origin.y))
                    - (Math.Abs(other.x - origin.x) + Math.Abs(other.y - origin.y));
            }
        }

        public int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {
            List<Point> points = new List<Point>();
            Point.origin = new Point(r0, c0);

            for (int r = 0; r < R; r++)
            {
                for (int c = 0; c < C; c++)
                {
                    points.Add(new Point(r, c));
                }
            }

            return points.OrderBy(p => p).Select(p => new int[] { p.x, p.y }).ToArray();
        }
    }
}
