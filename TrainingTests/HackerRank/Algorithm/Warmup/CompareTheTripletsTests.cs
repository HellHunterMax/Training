using System.Collections.Generic;
using System.Linq;
using Training.HackerRank.Algorithm.Warmup;
using Xunit;

namespace TrainingTests.HackerRank.Algorithm.Warmup
{
    public class CompareTheTripletsTests
    {
        [InlineData(new int[] { 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 0, 1, 1 })]
        [InlineData(new int[] { 0, 0 }, new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 })]
        [InlineData(new int[] { 3, 0 }, new int[] { 1, 1, 1 }, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 0, 3 }, new int[] { 0, 0, 0 }, new int[] { 1, 1, 1 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 0, 0, 1 }, new int[] { 1, 1, 0 })]
        [InlineData(new int[] { 2, 1 }, new int[] { 1, 1, 0 }, new int[] { 0, 0, 1 })]
        [InlineData(new int[] { 0, 3 }, new int[] { 0, 0, 0 }, new int[] { 99999, 99999, 99999 })]
        [Theory]
        public void CompareTriplets(int[] expected, int[] a, int[] b)
        {
            CompareTheTriplets compareTheTriplets = new CompareTheTriplets();

            var actual = compareTheTriplets.CompareTriplets(a.ToList(), b.ToList());

            Assert.Equal(expected, actual);
        }
    }
}
