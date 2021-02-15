using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week2;
using Xunit;

namespace TrainingTests.LeetCode.februari.week2
{
    public class ShortestPathInBinaryMatrixTests
    {
        [Fact]
        public void ShortestPathInBinaryMatrix_Given_Matrix_Returns_ShortestPath()
        {
            int[][] arrArr = new int[][] { new int[] { 0, 0, 0 }, new int[] { 1, 1, 0 }, new int[] { 1, 1, 0 } };

            var actual = ShortestPathInBinaryMatrix.ShortestPathBinaryMatrix(arrArr);

            Assert.Equal(4, actual);
        }
    }
}
