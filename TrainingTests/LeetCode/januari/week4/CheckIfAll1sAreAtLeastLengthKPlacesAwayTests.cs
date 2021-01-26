using Training.LeetCode.januari.week4;
using Xunit;

namespace TrainingTests.LeetCode.januari.week4
{
    public class CheckIfAll1sAreAtLeastLengthKPlacesAwayTests
    {
        [Theory]
        [InlineData(true, new int[] { 1, 0, 0, 0, 1, 0, 0, 1 }, 2)]
        [InlineData(false, new int[] { 1, 0, 0, 1, 0, 1 }, 2)]
        [InlineData(true, new int[] { 1, 1, 1, 1, 1 }, 0)]
        [InlineData(true, new int[] { 0, 1, 0, 1 }, 1)]
        [InlineData(true, new int[] { 0, 0, 0, 0 }, 1)]
        public void CheckIfAll1sAreAtLeastLengthKPlacesAway_Given_ArrayAndK_ReturnsTrueOrFalse(bool expected, int[] nums, int k)
        {
            var actual = CheckIfAll1sAreAtLeastLengthKPlacesAway.KLengthApart(nums, k);

            Assert.Equal(expected, actual);
        }
    }
}
