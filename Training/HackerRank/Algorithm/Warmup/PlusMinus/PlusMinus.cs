using System;
using System.Collections.Generic;
using System.Text;

namespace Training.HackerRank.Algorithm.Warmup.PlusMinus
{
    public static class PlusMinus
    {
        static void plusMinus(int[] arr)
        {
            var total = arr.Length;
            decimal plus = 0;
            decimal negative = 0;
            decimal zero = 0;

            for (var i = 0; i < total; i++)
            {
                if (arr[i] < 0)
                {
                    negative++;
                    continue;
                }
                if (arr[i] > 0)
                {
                    plus++;
                    continue;
                }
                zero++;
                /*
                switch (arr[i])
                {
                    case < 0:
                        negative++;
                        break;
                    case > 0:
                        plus++;
                        break;
                    default:
                        zero++;
                        break;
                }
                */
            }
            var plusDecimal = plus / total;
            decimal negativeDecimal = negative / total;
            decimal zeroDecimal = zero / total;

            Console.WriteLine(plusDecimal);
            Console.WriteLine(negativeDecimal);
            Console.WriteLine(zeroDecimal);
        }
    }
}
