using Training.Other;
using Xunit;

namespace TrainingTests.Other
{
    public class TreeTests
    {
        [Theory]
        [InlineData(new string[] { "--*--", "-***-", "*****" }, 3)]
        [InlineData(new string[] { "---*---", "--***--", "-*****-", "*******" }, 4)]
        [InlineData(new string[] { "*" }, 1)]
        public void Tree_GivenHeight_Returns_TreeOfHeight(string[] expected, int height)
        {
            Tree tree = new Tree(height);

            Assert.Equal(expected, tree.XmasTree);


        }
    }
}
