using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week2;
using Xunit;

namespace TrainingTests.LeetCode.februari.week2
{
    public class ValidAnagramTests
    {
        [InlineData(true, "s", "s")]
        [InlineData(false, "t", "s")]
        [InlineData(true, "anagram", "nagaram")]
        [InlineData(false, "rat", "Car")]
        [InlineData(true, "tts", "stt")]
        [InlineData(false, "tss", "stt")]
        [Theory]
        public void IsAnagram_Given_TwoStrings_Returns_IfAnagram(bool expected, string s, string t)
        {
            bool actual = ValidAnagram.IsAnagram(s, t);

            Assert.Equal(expected, actual);
        }
    }
}
