using System;
using System.Collections.Generic;
using System.Text;

namespace Day_31
{
    class Video_Stitching
    {
        static int VideoStitching(int[][] clips, int T)
        {
            int result = 1;

            List<int[]> clips_list = new List<int[]>();
            foreach (int[] clip in clips)
            {
                clips_list.Add(clip);
            }

            clips_list.Sort(delegate (int[] c1, int[] c2) { return c1[1].CompareTo(c2[1]); });

            if (clips_list[clips_list.Count - 1][1] < T)
            {
                return -1;
            }

            int start = 0;
            while (start <= T)
            {
                if (start >= T)
                {
                    break;
                }
                List<int[]> current_loop = new List<int[]>();
                for (int i = 0; i < clips_list.Count; i++)
                {
                    if (clips_list[i][0] <= start && clips_list[i][1]!=start)
                    {
                        current_loop.Add(clips_list[i]);
                    }
                }
                if (current_loop.Count == 0)
                {
                    return -1;
                }
                int min = 0;
                int min_index = 0;
                for (int i = 0; i < current_loop.Count; i++)
                {
                    int[] item = current_loop[i];
                    if (item[1] - item[0] >= min)
                    {
                        min_index = i;
                    }
                }
                start = current_loop[min_index][1];
                if (start >= T)
                {
                    break;
                }
                result++;
            }
            return result;
        }
        static void Main(String[] args)
        {
            Console.WriteLine(VideoStitching(
                new int[][]
                {
                    new int[]{ 0, 2 },
                    new int[]{4, 6 },
                    new int[]{8, 10 },
                    new int[]{1, 9 },
                    new int[]{1, 5 },
                    new int[]{5, 9 }
                }, 10
            ));
            Console.WriteLine(VideoStitching(
                new int[][]
                {
                    new int[]{ 0, 1 },
                    new int[]{ 1, 2 },
                },
                5));
            Console.WriteLine(VideoStitching(
                new int[][]
                {
                    new int[]{ 0, 1 },
                    new int[] { 6, 8 },
                    new int[] { 0, 2 },
                    new int[] { 5, 6 },
                    new int[] { 0, 4 },
                    new int[] { 0, 3 },
                    new int[] { 6, 7 },
                    new int[] { 1, 3 },
                    new int[] { 4, 7 },
                    new int[] { 1, 4 },
                    new int[] { 2, 5 },
                    new int[] { 2, 6 },
                    new int[] { 3, 4 },
                    new int[] { 4, 5 },
                    new int[] { 5, 7 },
                    new int[] { 6, 9 },
                },
                9));
            Console.WriteLine(VideoStitching(
                new int[][]
                {
                    new int[]{ 0,4 },
                    new int[]{ 2,8}
                },
                5
                ));
        }
    }
}
