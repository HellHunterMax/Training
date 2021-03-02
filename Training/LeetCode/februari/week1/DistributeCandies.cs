using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week1
{
    public static class DistributeCandies
    {
        //https://leetcode.com/problems/distribute-candies/submissions/
        public static int Distribute(int[] candyType)
        {
            int numberOfCandiesToBeEaten = candiesDevidedBy2(candyType);
            HashSet<int> hash = new HashSet<int>();

            for (int i = 0; i < candyType.Length; i++)
            {
                
                if(!hash.Contains(candyType[i]))
                {
                    hash.Add(candyType[i]);
                    if (hash.Count == numberOfCandiesToBeEaten)
                    {
                        break;
                    }
                }
            }

            return hash.Count;

        }

        private static int candiesDevidedBy2(int[] candyType)
        {
            return candyType.Length / 2;
        }
    }
}
