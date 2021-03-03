using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week1;
using Xunit;

namespace TrainingTests.LeetCode.februari.week1
{
    public class SetMismatchTests
    {
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 1})]
        [InlineData(new int[] { 2, 3 }, new int[] { 1, 2, 2, 4 })]
        [InlineData(new int[] { 2, 1 }, new int[] { 3, 2, 2 })]
        [InlineData(new int[] { 3, 2 }, new int[] { 8, 7, 3, 5, 3, 6, 1, 4 })]
        [InlineData(new int[] { 3, 1 }, new int[] { 3, 2, 3, 4, 6, 5 })]
        [InlineData(new int[] { 2, 10 }, new int[] { 1, 5, 3, 2, 2, 7, 6, 4, 8, 9 })]
        [Theory]
        public void FindErrorNums_Given_Array_Returns_TwoNumbersFirstOriginalSecondExpected(int[] expected, int[] s)
        {
            var actual = SetMismatch.FindErrorNums(s);

            Assert.Equal(expected, actual);
        }
    }
}
