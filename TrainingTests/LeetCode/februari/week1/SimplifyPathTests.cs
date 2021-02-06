using Training.LeetCode.februari.week1;
using Xunit;

namespace TrainingTests.LeetCode.februari.week1
{
    public class SimplifyPathTests
    {
        [InlineData("/home", "/home/")]
        [InlineData("/", "/../")]
        [InlineData("/home/foo", "/home//foo/")]
        [InlineData("/c", "/a/./b/../../c/")]
        [Theory]
        public void SimplifyPath_Given_Path_Simplifies(string expected, string input)
        {
            var actual = SimplifyPath.Simplify(input);

            Assert.Equal(expected, actual);
        }
    }
}
