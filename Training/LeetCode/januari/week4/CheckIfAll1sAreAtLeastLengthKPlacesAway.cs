using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.januari.week4
{
    public static class CheckIfAll1sAreAtLeastLengthKPlacesAway
    {
        public static bool KLengthApart(int[] nums, int k)
        {
            if (!nums.Contains(1))
            {
                return true;
            }
            if (k == 0)
            {
                if (nums.Contains(0))
                {
                    return false;
                }
            }

            int place1 = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    if (place1 != -1)
                    {
                        if (i - place1 -1 < k)
                        {
                            return false;
                        }
                        place1 = i;
                    }
                    else
                    {
                        place1 = i;
                    }
                }
            }
            return true;
        }
    }
}
