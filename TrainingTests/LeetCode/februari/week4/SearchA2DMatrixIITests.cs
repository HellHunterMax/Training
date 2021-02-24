using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week4;
using Xunit;

namespace TrainingTests.LeetCode.februari.week4
{
    public class SearchA2DMatrixIITests
    {
        [InlineData(true, 1 )]
        [InlineData(false, 20)]
        [InlineData(true, 5)]
        [InlineData(false, 60)]
        [Theory]
        public void SearchMatrix_Given_NumberAndMatrix_Returns_IfNumberIsInMatrix(bool IsInMatrix, int target)
        {
            int[][] matrix = new int[][]
            {
                new int[]{ 1,4,7,11,15 },new int[]{2,5,8,12,19 },new int[]{3,6,9,16,22 },new int[]{10,13,14,17,24 },new int[]{ 18, 21, 23, 26, 30 }
            };

            bool actual = SearchA2DMatrixII.SearchMatrix(matrix, target);

            if (IsInMatrix)
            {
                Assert.True(actual);
            }
            else if (!IsInMatrix)
            {
                Assert.False(actual);
            }
        }
    }
}
