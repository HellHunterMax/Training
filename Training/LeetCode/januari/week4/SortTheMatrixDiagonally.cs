using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.januari.week4
{
    public static class SortTheMatrixDiagonally
    {
        public static int[][] DiagonalSort(int[][] mat)
        {
            return FirstTry(mat);
        }

        public static int[][] FirstTry(int[][] mat)
        {
            int height = mat.Length;
            int width = mat[0].Length;

            int[][] final = mat;

            List<List<int>> diagonnal = new List<List<int>>();

            for (int i = 0; i < width + height -1; i++)
            {
                diagonnal.Add(new List<int>());
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int index = j - i;
                    if (index < 0)
                    {
                        index = Math.Abs(index) + width -1;
                    }
                    diagonnal[index].Add(mat[i][j]);
                }
            }
            for (int i = 0; i < width + height - 1; i++)
            {
                diagonnal[i].Sort();
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int index = j - i;
                    if (index < 0)
                    {
                        index = Math.Abs(index) + width - 1;
                    }
                    mat[i][j] = diagonnal[index].First();
                    diagonnal[index].Remove(diagonnal[index].First());
                }
            }

            return final;
        }
    }
}
