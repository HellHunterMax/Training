using System.Collections.Generic;
using Training.HackerRank.Algorithm.Warmup;
using Xunit;

namespace TrainingTests.HackerRank.Algorithm.Warmup
{
    public class DiagonalDifferenceTests
    {
        [Fact]
        public void DiagonalDifference_Given_EqualSquareMatrix_Returns_Zero()
        {
            //Assemble
            int expected = 0;
            List<List<int>> matrix = new List<List<int>>
            {
                new List<int>() { 1, 1, 1 },
                new List<int>() { 1, 1, 1 },
                new List<int>() { 1, 1, 1 }
            };

            //Act
            int actual = DiagonalDifference.Difference(matrix);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DiagonalDifference_Given_DifferentSquareMatrix_Returns_2()
        {
            //Assemble
            int expected = 0;
            List<List<int>> matrix = new List<List<int>>
            {
                new List<int>() { 3, 1, 1 },
                new List<int>() { 1, 1, 1 },
                new List<int>() { 1, 1, 1 }
            };

            //Act
            int actual = DiagonalDifference.Difference(matrix);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DiagonalDifference_Given_BiggerSquareMatrix_Returns_5()
        {
            //Assemble
            int expected = 0;
            List<List<int>> matrix = new List<List<int>>
            {
                new List<int>() { 1, 1, 1, 1 },
                new List<int>() { 1, 1, 1, 1 },
                new List<int>() { 1, 1, 1, 1 },
                new List<int>() { 1, 1, 1, 6 }
            };

            //Act
            int actual = DiagonalDifference.Difference(matrix);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
