using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.februari.week1
{
    public static class LongestHarmoniousSubsequence
    {
        public static int FindLHS(int[] nums)
        {
            return FirstGo(nums);
        }
        private static int FirstGo(int[] nums)
        {
            var diff = (from num in nums
                            group num by num
                            into g orderby g.Key ascending
                            select new { Count = g.Count(), Value = g.Key }).ToList();

            List<int> possibles = new List<int>();
            for (int i = 1; i < diff.Count(); i++)
            {
                if(diff[i].Value - diff[i -1].Value == 1)
                {
                    possibles.Add(diff[i].Count + diff[i - 1].Count);
                }
            }

            if (possibles.Count == 0)
            {
                return 0;
            }

            return possibles.Max();
        }
    }
}
