using System;
using Training.HackerRank.Algorithm.Warmup;
using Xunit;

namespace TrainingTests.HackerRank.Algorithm.Warmup
{
    public class SimpleArraySumTests
    {
        [InlineData(new int[] { 0 }, 0)]
        [InlineData(new int[] { 0, 1 }, 1)]
        [InlineData(new int[] { 0, -1 }, -1)]
        [InlineData(new int[] { 1, 1 }, 2)]
        [InlineData(new int[] { 2, -3 }, -1)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { -1, -1 }, -2)]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, 5)]
        [Theory]
        public void SimpleArraySum_Given_IntArray_Returns_Sum(int[] arr, int expected)
        {
            int actual = SimpleArraySum.SimpleArraySumLINQ(arr);

            Assert.Equal(expected, actual);
        }

        [InlineData(new int[] { 0 }, 0)]
        [InlineData(new int[] { 0, 1 }, 1)]
        [InlineData(new int[] { 0, -1 }, -1)]
        [InlineData(new int[] { 1, 1 }, 2)]
        [InlineData(new int[] { 2, -3 }, -1)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { -1, -1 }, -2)]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, 5)]
        [Theory]
        public void SimpleArraySumOwn_Given_IntArray_Returns_Sum(int[] arr, int expected)
        {
            int actual = SimpleArraySum.SimpleArraySumLINQ(arr);

            Assert.Equal(expected, actual);
        }
    }
}
