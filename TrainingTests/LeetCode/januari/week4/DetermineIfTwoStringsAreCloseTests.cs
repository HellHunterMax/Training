using Training.LeetCode.januari.week4;
using Xunit;

namespace TrainingTests.LeetCode.januari.week4
{
    public class DetermineIfTwoStringsAreCloseTests
    {
        [Theory]
        [InlineData(true, "","")]
        [InlineData(false, "a", "cd")]
        [InlineData(true, "cabbba", "abbccc")]
        [InlineData(false, "abbzzca", "babzzcz")]
        [InlineData(false, "abbzzcag", "babzzczd")]
        public void DetermineIfTwoStringsAreClose_Given_TwoStrings_Returns_CloseOrFalse(bool expected, string word1, string word2)
        {
            var actual = DetermineIfTwoStringsAreClose.CloseStrings(word1, word2);

            Assert.Equal(expected, actual);
        }
    }
}
