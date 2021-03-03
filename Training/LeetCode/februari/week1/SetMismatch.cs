using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week1
{
    public static class SetMismatch
    {
        public static int[] FindErrorNums(int[] nums)
        {
            Array.Sort(nums);

            return FindMissingNumber(nums);
        }
        
        private static int[] FindMissingNumber(int[] nums)
        {
            for (int i = 0; i < nums.Length +1; i++)
            {
                if (nums[i] != i + 1)
                {
                    return new int[] { nums[i], i + 1 };
                }
            }
            return new int[] { -1, -1 };
        }
        /*
        private static int[] Backward(int[] nums)
        {
            int number = 1;
            for (int i = nums.Length -1; i >= 0; i--, number++)
            {
                if (nums[i] != number)
                {
                    return new int[] { nums[i], number };
                }
            }

            return new int[] { -1, -1 };
        }*/
    }
}
