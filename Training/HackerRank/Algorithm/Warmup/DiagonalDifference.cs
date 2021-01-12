using System;
using System.Collections.Generic;
using System.Text;

namespace Training.HackerRank.Algorithm.Warmup
{
    public static class DiagonalDifference
    {
        public static int Difference(List<List<int>> arr)
        {
            int a = 0;
            int b = 0;

            int j = arr.Count - 2;
            int k = 1;
            for (int i = 0; i < arr.Count - 1; i++, k++, j--)
            {
                a += arr[k][i];
                b += arr[k][j];
            }
            int c = a - b;

            return Math.Abs(c);

        }

    }
}
