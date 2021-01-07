using Training;
using Xunit;

namespace TrainingTests
{
    public class KthMissingPositiveNumberTests
    {
        [InlineData(2, new int[1] { 1 }, 1)]
        [InlineData(5, new int[5] { 1, 2, 3, 4, 6}, 1)]
        [InlineData(7, new int[5] { 1, 2, 3, 4, 6 }, 2)]
        [InlineData(7, new int[4] { 1, 2, 3, 6 }, 3)]
        [InlineData(10, new int[4] { 1, 2, 3, 6 }, 6)]
        [InlineData(11, new int[5] { 1, 2, 3, 6, 10}, 6)]
        [InlineData(12, new int[6] { 1, 2, 3, 6, 10, 11 }, 6)]
        [InlineData(14, new int[6] { 1, 2, 3, 6, 10, 11 }, 8)]
        [InlineData(5, new int[0], 5)]
        [InlineData(1, new int[0], 1)]
        [InlineData(500, new int[0], 500)]
        [Theory]
        public void FindKthPositive_Given_Array_Returns_Expected(int expected, int[] arr, int k)
        {
            int actual = KthMissingPositiveNumber.FindKthPositive(arr, k);

            Assert.Equal(expected, actual);
        }
    }
}
