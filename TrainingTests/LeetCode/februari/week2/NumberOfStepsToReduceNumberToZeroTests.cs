using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week2;
using Xunit;

namespace TrainingTests.LeetCode.februari.week2
{
    public class NumberOfStepsToReduceNumberToZeroTests
    {
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 8)]
        [InlineData(6, 14)]
        [Theory]
        public void NumberOfSteps_Given_Number_Returns_NumberOfStepsNeeded(int expected, int num)
        {
            var actual = NumberOfStepsToReduceNumberToZero.NumberOfSteps(num);

            Assert.Equal(expected, actual);
        }
    }
}
