using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week3;
using Xunit;

namespace TrainingTests.LeetCode.februari.week3
{
    public class KWeakestRowsTests
    {
        [Fact]
        public void KWeakestRows_Given_Rows_Returns_Weakest()
        {
            int[][] rows = new int[][]
            {
                new int[]{ 1, 1, 0, 0, 0 },new int[]{1, 1, 1, 1, 0 },new int[]{1, 0, 0, 0, 0 },new int[]{1, 1, 0, 0, 0 },new int[]{1, 1, 1, 1, 1 }
            };
            int[] expected = new int[] { 2, 0, 3 };

            var actual = TheKWeakestRowsInAMatrix.KWeakestRows(rows, 3);

            Assert.Equal(expected, actual);

        }
    }
}
