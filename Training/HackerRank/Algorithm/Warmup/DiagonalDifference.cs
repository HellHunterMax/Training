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

            int j = arr.Count - 1;
            for (int i = 0; i < arr.Count; i++, j--)
            {
                a += arr[i][i];
                b += arr[j][j];
            }

            return Math.Abs((a - b));
            
        }

    }
}
