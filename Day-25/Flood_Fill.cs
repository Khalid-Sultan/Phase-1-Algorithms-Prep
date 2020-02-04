using System;
using System.Collections.Generic;
using System.Text;

namespace Day_25
{
    class Flood_Fill
    {
        static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            //First find the color in the current node
            int color = image[sr][sc];

            if (color != newColor)
            {
                DFS(image, sr, sc, newColor, color);
            }
            return image;
        }

        static void DFS(int[][] image, int sr, int sc, int newColor, int prevColor)
        {
            //First find the color in the current node
            int currentColor = image[sr][sc];

            if (currentColor == prevColor)
            {
                image[sr][sc] = newColor;
                if (sr >= 1)
                {
                    DFS(image, sr - 1, sc, newColor, currentColor);
                }
                if (sr+1 < image.Length)
                {
                    DFS(image, sr + 1, sc, newColor, currentColor);
                }

                if (sc >= 1)
                {
                    DFS(image, sr, sc - 1, newColor, currentColor);
                }
                if (sc+1 < image[0].Length)
                {
                    DFS(image, sr, sc + 1, newColor, currentColor);
                }
            }
        }
    }
}
