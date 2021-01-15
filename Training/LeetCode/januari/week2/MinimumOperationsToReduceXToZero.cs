using System.Collections.Generic;

namespace Training.LeetCode.januari.week2
{
    //Gave up on this one very hard for me to grasp and late... will watch more video's on the subject
    //TODO watch more on this subject
    public static class MinimumOperationsToReduceXToZero
    {
        /*
        public static int MinOperations(int[] nums, int x)
        {
            return FirstGo(nums, x);
        }

        private static int FirstGo(int[] nums, int x)
        {
            List<int> leftToRight = new List<int>();
            List<int> rightToLeft = new List<int>();
            int left = 0;
            int right = nums.Length - 1;
            int number = 0;
            while (left <= right && number + nums[left] <= x)
            {
                number += nums[left];
                leftToRight.Add(number);
                left++;
            }
            number = 0;
            while (right > 0 && number + nums[right] <= x)
            {
                number += nums[right];
                rightToLeft.Add(number);
                right--;
            }
            left = leftToRight.Count;
            right = rightToLeft.Count;
            int total = 0;
            int biggestOneSideLeft = leftToRight.IndexOf(x);
            int biggestOneSideRight = rightToLeft.IndexOf(x);
            /*
            x = 5[1, 1, 4, 2, 3];

            left to right = [1, 2]; left = 2 biggest -1
            right to left = [3, 5]; right = 2 biggest = 1
            
            11 - 5 = 6
            sum -x = rest
            rest - x = sum
            if (left == 0 && right == 0)
            {
                //Both Sides start with higher number then x
                return -1;
            }
            if (leftToRight[left - 1] + rightToLeft[right - 1] < x)
            {
                //sum of both is too low
                return -1;
            }

            if (biggestOneSideLeft < 0)
            {
                //int number to check from is right
            }
            else
            {
                //int number to check from is left
            }

            for (int i = 0; i < left && i < right; i++)
            {

            }
            return -1;
        }

        private static int AfteryYoutubeGo(int[] nums, int x)
        {

            //make a dictionary int int
            // link number with sum start 

            Dictionary<int, int> map = new Dictionary<int, int>();
            List<int> listNums = new List<int>();

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                map.Add(sum, i);
                listNums.Add(sum);
            }

            int rest = sum - x;
            int longest = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (listNums.GetRange(0, i).Contains(rest))
                {
                    longest = i + 1;
                }
            }
        }
        */
    }

}
