using Training;
using Xunit;

namespace TrainingTests
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [InlineData(3, "abcabcbb")]
        [InlineData(1, "bbbbb")]
        [InlineData(0, "")]
        [InlineData(3, "pwwkew")]
        [Theory]
        public void TheoryTest(int expected, string s)
        {
            int actual = LongestSubstringWithoutRepeatingCharacters.Get(s);

            Assert.Equal(expected, actual);
        }
    }
}
