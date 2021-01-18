using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.januari.week3
{
    public static class MaxNumberOfKSumPairs
    {
        public static  int MaxOperations(int[] nums, int k)
        {

            return FirstGo(nums, k);

        }

        private static int FirstGo(int[] nums, int k)
        {
            List<int> list = nums.ToList();

            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; k < list.Count; k++)
                {
                    if (list[i] + list[j] == k)
                    {
                        list.RemoveAt(j);
                        list.RemoveAt(i);
                        i--;
                        count++;
                        break;
                    }
                }
            }

            return count;
        }

    }
}
