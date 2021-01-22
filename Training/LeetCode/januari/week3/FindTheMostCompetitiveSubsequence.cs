using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.januari.week3
{
    public static class FindTheMostCompetitiveSubsequence
    {
        public static int[] MostCompetitive(int[] nums, int k)
        {
            return SecondTry(nums, k);
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

        private static int[] SecondTry(int[] nums, int k)
        {
            int[] winner = new int[k];
            int last = 0;

            for (int i = 0; i < k; i++)
            {
                int[] anArray = new int[nums.Length - (k - i) - last +1];

                int j = last;
                for (int l = 0; l < anArray.Length; l++, j++)
                {
                    anArray[l] = nums[j];
                }

                winner[i] = anArray.Min();
                last += Array.IndexOf(anArray, winner[i]) + 1;
            }
            return winner;
        }
    }
}
