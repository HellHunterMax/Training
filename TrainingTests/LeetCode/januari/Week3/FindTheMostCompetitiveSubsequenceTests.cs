using Training.LeetCode.januari.week3;
using Xunit;

namespace TrainingTests.LeetCode.januari.Week3
{
    public class FindTheMostCompetitiveSubsequenceTests
    {
        [Theory]
        [InlineData(new int[] {2, 6 }, new int[] { 3, 5, 2, 6 }, 2)]
        [InlineData(new int[] { 2, 3, 3, 4 }, new int[] { 2, 4, 3, 3, 5, 4, 9, 6 }, 4)]
        public void FindTheMostCompetitiveSubsequence_Given_Array_Returns_FindTheMostCompetitiveArray(int[] expected, int[] nums, int k)
        {
            var actual = FindTheMostCompetitiveSubsequence.MostCompetitive(nums, k);

            Assert.Equal(expected, actual);
        }
    }
}
