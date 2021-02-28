using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week4;
using Xunit;

namespace TrainingTests.LeetCode.februari.week4
{
    public class DivideTwoIntegersTests
    {
        [InlineData(1, 1, 1)]
        [InlineData(0, 0, 1)]
        [InlineData(2, 4, 2)]
        [InlineData(0, 1, 3)]
        [InlineData(3, 10, 3)]
        [InlineData(-2, 7, -3)]
        [InlineData(2, -4, -2)]
        [InlineData(-2, -4, 2)]
        [InlineData(0, 1, 2)]
        [Theory]
        public void DivideTwoIntegers_Given_TwoInts_Divides(int expected, int dividend, int divisor)
        {
            var actual = DivideTwoIntegers.Divide(dividend, divisor);

            Assert.Equal(expected, actual);


        }
    }
}
