using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.januari.week3
{
    public static class GetMaximumInGeneratedArray
    {
        public static int getMaximumGenerated(int n)
        {
            List<int> nums = new List<int>{0, 1};
            for (int i = 1; i < n; i++)
            {
                nums.Add(0);
            }
            for (int i = 1; i < n; i++)
            {
                if (2 * i < nums.Count)
                {
                    nums[2 * i] = nums[i];
                }
                if (2 * i + 1 < nums.Count)
                {
                    nums[2 * i + 1] = nums[i] + nums[i + 1];
                }
            }
            return nums.Max();
        }
    }
}
