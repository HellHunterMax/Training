using Training.LeetCode.januari.week4;
using Xunit;

namespace TrainingTests.LeetCode.januari.week4
{
    public class ConcatenationOfConsecutiveBinaryNumbersTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(27, 3)]
        [InlineData(505379714, 12)]
        [InlineData(385951001, 24)]
        [InlineData(727837408, 42)]
        public void ConcatenationOfConsecutiveBinaryNumbers_Given_NumberN_Returns_NumberChangedToBinaryThenToDecimal(int expected, int n)
        {
            int actual = ConcatenationOfConsecutiveBinaryNumbers.ConcatenatedBinary(n);

            Assert.Equal(expected, actual);
        }
    }
}
