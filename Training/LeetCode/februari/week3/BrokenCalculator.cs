using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week3
{
    public static class BrokenCalculator
    {
        public static int Calculate(int X, int Y)
        {
            int count = 0;
            if (X > Y)
            {
                count += Math.Abs(Y - X);
            }
            return count;
        }
    }
}
