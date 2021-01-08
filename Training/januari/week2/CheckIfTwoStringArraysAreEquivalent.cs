using System;

namespace Training.januari.week2
{
    public static class CheckIfTwoStringArraysAreEquivalent
    {
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            return String.Join("", word1) == String.Join("", word2);
        }
    }
}
