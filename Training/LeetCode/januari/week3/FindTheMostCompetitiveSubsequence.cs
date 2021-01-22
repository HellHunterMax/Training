using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.januari.week3
{
    public static class FindTheMostCompetitiveSubsequence
    {
        public static int[] MostCompetitive(int[] nums, int k)
        {
            return FirstTry(nums, k);
        }

        private static int[] FirstTry(int[] nums, int k)
        {
            int[] winner = new int[k];
            int last = 0;

            for (int i = 0; i < k; i++)
            {
                winner[i] = int.MaxValue;

                for (int j = last; j <= nums.Length - (k - i); j++)
                {

                    if (nums[j] < winner[i])
                    {
                        last = j + 1;
                        winner[i] = nums[j];
                    }
                }
            }
            return winner;
        }
    }
}
