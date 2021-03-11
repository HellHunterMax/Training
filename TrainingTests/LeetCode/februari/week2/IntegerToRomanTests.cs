using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week2;
using Xunit;

namespace TrainingTests.LeetCode.februari.week2
{
    public class IntegerToRomanTests
    {
        [InlineData("I", 1)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("L", 50)]
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
        [InlineData("MMMCMXCIX", 100)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [Theory]
        public void Convert_Given_Int_Returns_RomanString(string expected, int num)
        {
            string actual = IntegerToRoman.Convert(num);

            Assert.Equal(expected, actual);
        }
    }
}
