using Training.LeetCode.januari.week4;
using Xunit;

namespace TrainingTests.LeetCode.januari.week4
{
    public class SortTheMatrixDiagonallyTests
    {
        [Fact]
        public void SortTheMatrixDiagonally_Given_Matrix_Returns_Sorted_Matrix()
        {
            int[][] mat = new int[][] { new int[] { 3, 3, 1, 1 }, new int[] { 2, 2, 1, 2 }, new int[] { 1, 1, 1, 2 } };
            int[][] expected = new int[][] { new int[] { 1, 1, 1, 1 }, new int[] { 1, 2, 2, 2 }, new int[] { 1, 2, 3, 3 } };

            int[][] actual = SortTheMatrixDiagonally.DiagonalSort(mat);

            Assert.Equal(expected, actual);
        }
    }
}
