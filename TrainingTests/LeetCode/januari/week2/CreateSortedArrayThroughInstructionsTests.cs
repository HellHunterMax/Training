using Training.LeetCode.januari.week2;
using Xunit;

namespace TrainingTests.LeetCode.januari.week2
{
    public class CreateSortedArrayThroughInstructionsTests
    {
        [InlineData(1, new int[] { 1, 5, 6, 2 })]
        [InlineData(3, new int[] { 1, 2, 3, 6, 5, 4 })]
        [InlineData(4, new int[] { 1, 3, 3, 3, 2, 4, 2, 1, 2 })]
        [InlineData(0, new int[] { 1, 2 })]
        [InlineData(0, new int[] { 1, 1, 1, 1, 1, 1, 1 })]
        [Theory]
        public void CreateSortedArrayThroughInstructions_Given_Array_Returns_CostOfSorting(int expected, int[] arr)
        {
            int actual = CreateSortedArrayThroughInstructions.CreateSortedArray(arr);

            Assert.Equal(expected, actual);
        }
    }
}
