using System.Linq;

namespace Training.HackerRank.Algorithm.Warmup
{
    public static class SimpleArraySum
    {
        public static int SimpleArraySumLINQ(int[] arr)
        {
            return arr.Sum();
        }

        public static int SimpleArraySumOwn(int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }

            return sum;
        }
    }
}
