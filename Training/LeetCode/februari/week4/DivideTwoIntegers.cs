using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week4
{
    public static class DivideTwoIntegers
    {
        public static int Divide(int dividend, int divisor)
        {
            throw new NotImplementedException();
        }

        private static int FirstTry(int dividend, int divisor)
        {
            if (divisor == 1)
            {
                return dividend;
            }
            if (divisor == -1)
            {
                return 0 - dividend;
            }

            int answer = 0;
            int absDividend = Math.Abs(dividend);
            int absDivisor = Math.Abs(divisor);

            int half = FindHalf(absDivisor);

            int remaining = absDividend;

            for (int i = 0; i < absDividend; i++)
            {
                if (remaining > absDivisor)
                {
                    if (remaining >= half)
                    {
                        answer++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    answer++;
                    remaining -= absDivisor;
                }
            }

            return answer;
        }

        private static int FindHalf(int absDivisor)
        {
            int count = 0;
            int half = 0;

            for (int i = 0; i < absDivisor; i++)
            {
                half++;
                count += 2;
                if (count >= absDivisor)
                {
                    break;
                }
            }
            return half;
        }
    }
}
