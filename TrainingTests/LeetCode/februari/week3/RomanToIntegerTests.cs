using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week3;
using Xunit;

namespace TrainingTests.LeetCode.februari.week3
{
    public class RomanToIntegerTests
    {
        [InlineData(1, "I")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        [Theory]
        public void RomanToInteger_Given_RomanLetters_Returns_Integer(int expected, string roman)
        {
            var actual = RomanToInteger.RomanToInt(roman);

            Assert.Equal(expected, actual);
        }
    }
}
