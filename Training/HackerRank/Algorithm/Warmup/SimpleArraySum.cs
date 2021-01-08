using System.Linq;

namespace Training.HackerRank.Algorithm.Warmup
{
    public static class SimpleArraySum
    {
        public static int simpleArraySum(int[] arr)
        {
            return arr.Sum();
        }

        public static int simpleArraySumOwn(int[] arr)
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
