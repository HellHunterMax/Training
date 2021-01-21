using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.januari.week3
{
    //https://leetcode.com/submissions/detail/444810470/?from=explore&item_id=3608
    //1,5 hours
    public static class MaxNumberOfKSumPairs
    {
        public static  int MaxOperations(int[] nums, int k)
        {

            return AfterYouTube(nums, k);

        }

        private static int FirstGo(int[] nums, int k)
        {
            List<int> list = nums.ToList();

            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {

                for (int j = i + 1; j < list.Count; j++)
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

        private static int SecondGo(int[] nums, int k)
        {
            List<int> list = nums.ToList();

            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int lookingForNumber = k - list[i];
                var num = list.FindAll(i => i == lookingForNumber);

                if (num.Count > 0)
                {
                    if (num[0] != list[i])
                    {
                        list.Remove(list[i]);
                        list.Remove(num[0]);
                        i--;
                        count++;
                    }
                    else
                    {
                        if (num.Count > 1)
                        {
                            list.Remove(list[i]);
                            list.Remove(num[0]);
                            i--;
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        private static int AfterYouTube(int[] nums, int k)
        {
            int count = 0;

            List<int> list = nums.ToList();

            list.Sort();

            int left = 0;
            int right = list.Count - 1;
            while ( left < right)
            {
                int sum = list[left] + list[right];
                if (sum == k)
                {
                    count++;
                    left++;
                    right--;
                }
                else if (sum < k)
                {
                    left++;
                }
                else if(sum > k)
                {
                    right--;
                }
            }

            return count;
        }

    }
}
