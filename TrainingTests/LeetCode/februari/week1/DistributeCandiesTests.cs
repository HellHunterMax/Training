using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week1;
using Xunit;

namespace TrainingTests.LeetCode.februari.week1
{
    public class DistributeCandiesTests
    {
        [InlineData(1, new int[] { 1,1})]
        [InlineData(2, new int[] { 1, 1, 2, 2 })]
        [InlineData(2, new int[] { 1, 1 , 2 , 3 })]
        [InlineData(4, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(1, new int[] { 1, 1, 1, 1, 1, 1, 1, 1  })]
        [Theory]
        public void Distribute_Given_ListOfCandies_Returns_NumberOfDifferentCandysCanBeEaten(int expected, int[] candies)
        {
            var actual = DistributeCandies.Distribute(candies);

            Assert.Equal(expected, actual);
        }
    }
}
