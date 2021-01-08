using System;

namespace Training.januari.week2
{
    //https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/580/week-2-january-8th-january-14th/3597/
    public static class CheckIfTwoStringArraysAreEquivalent
    {
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            return String.Join("", word1) == String.Join("", word2);
        }
    }
}
