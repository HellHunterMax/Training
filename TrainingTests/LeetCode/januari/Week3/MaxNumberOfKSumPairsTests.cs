using Training.LeetCode.januari.week3;
using Xunit;

namespace TrainingTests.LeetCode.januari.Week3
{
    public class MaxNumberOfKSumPairsTests
    {

        [Theory]
        [InlineData(2, new int[] { 1, 2, 3, 4 }, 5)]
        public void MaxNumberOfKSumPairs_Given_ArrayAndNumber_Returns_NumberOfOpperationsPossible(int expected, int[] nums, int k)
        {
            int actual = MaxNumberOfKSumPairs.MaxOperations(nums, k);

            Assert.Equal(expected, actual);
        }
    }
}
