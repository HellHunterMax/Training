using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week2
{
    public static class NumberOfStepsToReduceNumberToZero
    {
        public static int NumberOfSteps(int num)
        {
            return FirstTry(num);
        }

        public static int FirstTry (int num)
        {
            int result = 0;

            while (num != 0)
            {
                if (num % 2 ==0)
                {
                    num = num / 2;
                }
                else
                {
                    num--;
                }
                result++;
            }
            return result;
        }
    }
}
