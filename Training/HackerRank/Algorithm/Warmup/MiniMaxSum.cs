using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.HackerRank.Algorithm.Warmup
{
    public static class MiniMaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            int length = arr.Count;

            arr.Sort();

            long smallest = AddFour(arr[0], arr[1], arr[2], arr[3]);
            long largest = AddFour(arr[length - 1], arr[length - 2], arr[length - 3], arr[length - 4]);
            Console.WriteLine($"{smallest} {largest}");


        }

        private static long AddFour(int a, int b, int c, int d)
        {
            return (long) a + b + c + d;
        }
    }
}
