using Training.LeetCode.januari.week2;
using Xunit;

namespace TrainingTests.LeetCode.januari.week2
{
    public class MinimumOperationsToReduceXToZeroTests
    {

        [Theory]
        [InlineData(2, new int[] { 1, 1, 4, 2, 3 }, 5)]
        [InlineData(-1, new int[] { 1 }, 5)]
        [InlineData(-1, new int[] { 2, 1, 4, 2, 3 }, 1)]
        [InlineData(5, new int[] { 3, 2, 20, 1, 1, 3 }, 10)]
        [InlineData(3, new int[] { 1, 40, 1, 1, 1, 1, 1, 1, 1, 1, 2, 33,1, 1, 1, 1, 1, 1, 1, 1, 9  }, 50)]

        public void MinOperations_Given_ArrayAndInt_Returns_MinimumToGetToZero(int expected, int[] nums, int x)
        {
            int actual = MinimumOperationsToReduceXToZero.MinOperations(nums, x);

            Assert.Equal(expected, actual);
        }
    }
}
