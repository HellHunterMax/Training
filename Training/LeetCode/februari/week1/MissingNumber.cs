using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week1
{
    public static class MissingNumber
    {
        public static int Find(int[] nums)
        {
            bool[] isNumberInNums = new bool[nums.Length+1];

            for (int i = 0; i < nums.Length; i++)
            {
                isNumberInNums[nums[i]] = true;
            }
            for (int i = 0; i < isNumberInNums.Length; i++)
            {
                if (!isNumberInNums[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static int Slow(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
