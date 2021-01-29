﻿using Training.LeetCode.januari.week4;
using Xunit;

namespace TrainingTests.LeetCode.januari.week4
{
    public class SmallestStringWithAGivenNumericValueTests
    {
        [Theory]
        [InlineData(3, 27, "aay")]
        [InlineData(1, 26, "z")]
        [InlineData(5, 73, "aaszz")]
        [InlineData(67, 882, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaapzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz")]
        public void SmallestStringWithAGivenNumericValue_Given_TwoNumbers_Returns_CorrectString(int nLength, int kValue, string expected)
        {
            string actual = SmallestStringWithAGivenNumericValue.GetSmallestString(nLength, kValue);

            Assert.Equal(expected, actual);
        }
    }
}
