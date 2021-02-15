using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week2
{
    public static class ShortestPathInBinaryMatrix
    {
        public static int ShortestPathBinaryMatrix(int[][] grid)
        {
            if (grid[0][0] == 1)
            {
                return -1;
            }

            int height = grid.Length;
            int width = grid[0].Length;

            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(new int[] { 0, 0, 1 });
            grid[0][0] = 1;

            int[,] possibleLocations = new int[,] { { 1, 1 }, { 0, 1 }, { 1, 0 }, { 1, -1 }, { -1, 1 }, { 0, -1 }, { -1, 0 }, { -1, -1 } };

            while (queue.Count > 0)
            {
                int size = queue.Count;
                while(size-- > 0)
                {
                    int[] point = queue.Dequeue();
                    if (point[0] ==height -1 && point[1] == width-1)
                    {
                        return point[2];
                    }
                    for (int i = 0; i < possibleLocations.GetLength(0); i++)
                    {
                        int row = point[0] + possibleLocations[i, 0];
                        int collumn = point[1] + possibleLocations[i, 1];

                        if (row < 0 || row >= height || collumn < 0 || collumn >= width || grid[row][collumn] == 1)
                        {
                            continue;
                        }
                        queue.Enqueue(new int[] { row, collumn, point[2] + 1 });
                        grid[row][collumn] = 1;
                    }
                }
            }
            return -1;
        }


    }
}
