using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week4
{
    public static class DivideTwoIntegers
    {
        public static int Divide(int dividend, int divisor)
        {
            return FirstTry(dividend, divisor);
        }

        private static int FirstTry(int dividend, int divisor)
        {
            if (divisor == 1 || dividend == 0)
            {
                return dividend;
            }
            if (divisor == -1)
            {
                if (dividend == -2147483648)
                {
                    return 2147483647;
                }
                return 0 - dividend;
            }

            long dividendL = dividend;
            long divisorL = divisor;

            long absDividend = Math.Abs(dividendL);
            long absDivisor = Math.Abs(divisorL);

            long answer = DevideAbsolute(absDividend, absDivisor);

            if ((divisor < 0 && dividend > 0)|| (dividend < 0 && divisor > 0))
            {
                answer = 0 - answer;
            }
            if (answer > 2147483647)
            {
                return 2147483647;
            }
            else
            {
                return Convert.ToInt32(answer);
            }
        }

        private static long DevideAbsolute(long absDividend, long absDivisor)
        {
            bool isTrueHalf = false;
            long half = FindHalf(absDivisor,ref isTrueHalf);
            long answer = 0;
            long remaining = absDividend;
            

            for (long i = 0; i < absDividend; i++)
            {
                if (remaining < absDivisor)
                {
                    if (remaining >= half)
                    {
                        if (isTrueHalf)
                        {
                            break;
                        }
                        answer++;
                        break;
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

        private static long FindHalf(long absDivisor, ref bool isTrueHalf)
        {
            long count = 0;
            long half = 0;

            for (long i = 0; i < absDivisor; i++)
            {
                half++;
                count += 2;
                if (count > absDivisor)
                {
                    break;
                }
                else if (count == absDivisor)
                {
                    isTrueHalf = true;
                    break;
                }
            }
            return half;
        }
    }
}
