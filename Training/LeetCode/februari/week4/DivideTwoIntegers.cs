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
                return 0 - dividend;
            }
            if (dividend == 1 || dividend == -1)
            {
                return 0;
            }

            int absDividend = Math.Abs(dividend);
            int absDivisor = Math.Abs(divisor);

            int answer = DevideAbsolute(absDividend, absDivisor);

            if ((divisor < 0 && dividend > 0)|| (dividend < 0 && divisor > 0))
            {
                answer = 0 - answer;
            }

            return answer;
        }

        private static int DevideAbsolute(int absDividend, int absDivisor)
        {
            bool isTrueHalf = false;
            int half = FindHalf(absDivisor,ref isTrueHalf);
            int answer = 0;
            int remaining = absDividend;
            

            for (int i = 0; i < absDividend; i++)
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

        private static int FindHalf(int absDivisor, ref bool isTrueHalf)
        {
            int count = 0;
            int half = 0;

            for (int i = 0; i < absDivisor; i++)
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
                /*
                else if (count == absDivisor)
                {
                    half--;
                    break;
                }*/
            }
            return half;
        }
    }
}
