using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week1;
using Xunit;

namespace TrainingTests.LeetCode.februari.week1
{
    public class MissingNumberTests
    {
        [InlineData(1, new int[] { 0 })]
        [InlineData(2, new int[] { 3, 0, 1 })]
        [InlineData(2, new int[] { 0, 1 })]
        [InlineData(8, new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 })]
        [Theory]
        public void Find_Given_Array_Returns_MissingNumber(int expected, int[] nums)
        {
            var actual = MissingNumber.Find(nums);

            Assert.Equal(expected, actual);
        }
    }
}
