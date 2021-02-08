using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week1;
using Xunit;

namespace TrainingTests.LeetCode.februari.week1
{
    public class ShortestDistanceToACharacterTests
    {
        [InlineData(new int[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 }, "loveleetcode", 'e')]
        [InlineData(new int[] { 3, 2, 1, 0 }, "aaab", 'b')]
        [InlineData(new int[] { 0 }, "b", 'b')]
        [Theory]
        public void ShortestDistanceToACharacter_Given_StringAndChar_Returns_ArrayWithDistanceToChar(int[] expected, string s, char c)
        {
            var actual = ShortestDistanceToACharacter.ShortestToChar(s, c);

            Assert.Equal(expected, actual);
        }
    }
}
