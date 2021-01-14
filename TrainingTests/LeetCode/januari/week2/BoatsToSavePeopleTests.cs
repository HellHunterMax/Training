using Training.LeetCode.januari.week2;
using Xunit;

namespace TrainingTests.LeetCode.januari.week2
{
    public class BoatsToSavePeopleTests
    {
        [Theory]
        [InlineData(1, new int[] { 1 }, 1)]
        [InlineData(1, new int[] { 1,  2}, 3)]
        [InlineData(3, new int[] { 3, 2, 2, 1 }, 3)]
        [InlineData(4, new int[] { 3, 5, 3, 4 }, 5)]
        public void BoatsToSavePeople_Given_PeopleAndLimit_Returns_NumberOfBoats(int expected, int[] people, int limit)
        {
            int actual = BoatsToSavePeople.NumRescueBoats(people, limit);

            Assert.Equal(expected, actual);
        }
    }
}
