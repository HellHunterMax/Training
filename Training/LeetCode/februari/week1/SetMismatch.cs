using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.februari.week1
{
    public static class SetMismatch
    {
        public static int[] FindErrorNums(int[] nums)
        {
            int duplicate = -1;
            int missingNumber = -1;

            Array.Sort(nums);

            var duplicateAndIndex = FindDuplicate(nums);
            duplicate = duplicateAndIndex[0];

            var numsList = nums.ToList();
            numsList.RemoveAt(duplicateAndIndex[1]);

            missingNumber = FindMissingNumber(numsList);

            return new int[] { duplicate, missingNumber };
        }

        private static int FindMissingNumber(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            { 
                if (nums[i] != i +1)
                {
                    return i + 1;
                }
            }
            return nums.Count +1;
        }
        
        /// <summary>
        /// finds dunplicate number and returns the number and index
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>First number, Second index</returns>
        private static int[] FindDuplicate(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hash.Contains(nums[i]))
                {
                    hash.Add(nums[i]);
                }
                else
                {
                    return new int[] { nums[i], i };
                }
            }
            return new int[] { -1, -1 };
        }
        /*
         * 
        private static int[] FindMissingNumber(int[] nums)
        {
            int missingNumber = -1;
            int duplicate = -1;
            if (nums[0] != 1)
            {
                missingNumber = 1;
            }
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (missingNumber > 0 && duplicate > 0)
                {
                    break;
                }
                if (!hash.Contains(nums[i]))
                {
                    hash.Add(nums[i]);
                }
                else
                {
                    duplicate = nums[i];
                }
                if (missingNumber < 0 && nums[i] != i +1)
                {
                    missingNumber = i + 1;
                }
            }
            return new int[] { duplicate, missingNumber };
        }
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
