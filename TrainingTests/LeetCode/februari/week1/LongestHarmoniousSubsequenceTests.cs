using Training.LeetCode.februari.week1;
using Xunit;

namespace TrainingTests.LeetCode.februari.week1
{
    public class LongestHarmoniousSubsequenceTests
    {

        [InlineData(5, new int[] { 1, 3, 2, 2, 5, 2, 3, 7 })]
        [InlineData(2, new int[] { 1, 2, 3, 4 })]
        [InlineData(0, new int[] { 1, 1, 1, 1 })]
        [Theory]
        public void LongestHarmoniousSubsequence_Given_Array_Returns_LHS(int expected, int[] nums)
        {
            var actual = LongestHarmoniousSubsequence.FindLHS(nums);

            Assert.Equal(expected, actual);
        }
    }
}
