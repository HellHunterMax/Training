using Training.LeetCode.januari.week3;
using Xunit;

namespace TrainingTests.LeetCode.januari.Week3
{
    public class GetMaximumInGeneratedArrayTests
    {
        [Theory]
        [InlineData(3, 7)]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        public void GetMaximumInGeneratedArray_given_Number_Returns_MaxInt(int expected, int n)
        {
            int actual = GetMaximumInGeneratedArray.getMaximumGenerated(n);

            Assert.Equal(expected, actual);
        }
    }
}
