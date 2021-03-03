using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week1
{
    public static class MissingNumber
    {
        public static int Find(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != i)
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
