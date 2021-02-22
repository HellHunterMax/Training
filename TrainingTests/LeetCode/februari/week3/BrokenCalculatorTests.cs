using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week3;
using Xunit;

namespace TrainingTests.LeetCode.februari.week3
{
    public class BrokenCalculatorTests
    {
        [InlineData(0, 1, 1)]
        [InlineData(2, 2, 3)]
        [InlineData(2, 5, 8)]
        [InlineData(3, 3, 10)]
        [InlineData(1023, 1024, 1)]
        [InlineData(39, 1, 1000000000)]
        [Theory]
        public void Calculate_Given_TwoInts_Returns_NumberOfOperationsNeeded(int expected, int start, int end)
        {
            var actual = BrokenCalculator.Calculate(start, end);

            Assert.Equal(expected, actual);
        }
    }
}
