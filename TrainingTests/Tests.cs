using Training;
using Xunit;

namespace TrainingTests
{
    public class Tests
    {
        [Fact]
        public void FactTest()
        {
            Assert.Equal(1, 1);
        }

        [InlineData(1,  1)]
        [Theory]
        public void TheoryTest(int expected,  int actual)
        {
            Assert.Equal(expected, actual);
        }
    }
}
