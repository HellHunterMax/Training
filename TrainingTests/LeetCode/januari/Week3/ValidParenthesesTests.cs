using Training.LeetCode.januari.week3;
using Xunit;

namespace TrainingTests.LeetCode.januari.Week3
{
    public class ValidParenthesesTests
    {
        [Theory]
        [InlineData(true, "()")]
        [InlineData(false, @"{(})")]
        [InlineData(true, @"{()}")]
        [InlineData(false, ")")]
        [InlineData(true, "([()])")]
        [InlineData(true, "(){}[]")]
        public void ValidParentheses_Given_String_Returns_TrueOrFalse(bool expected, string s)
        {
            bool actual = ValidParentheses.IsValid(s);

            Assert.Equal(expected, actual);
        }
    }
}
