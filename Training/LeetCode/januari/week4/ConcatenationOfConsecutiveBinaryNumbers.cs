using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace Training.LeetCode.januari.week4
{
    public static class ConcatenationOfConsecutiveBinaryNumbers
    {
        public static int ConcatenatedBinary(int n)
        {
            return FirstTry(n);
        }

        public static int FirstTry(int n)
        {
            string binary = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                binary += Convert.ToString(i, 2);
            }

            // BigInteger can be found in the System.Numerics dll
            BigInteger res = 0;

            // I'm totally skipping error handling here
            foreach (char c in binary)
            {
                res <<= 1;
                res += c == '1' ? 1 : 0;
            }

            string resString = res.ToString();


            double doub = Convert.ToDouble(resString);

            double m = 1000000007;

            return Convert.ToInt32(doub % m);
        }
    }
}
