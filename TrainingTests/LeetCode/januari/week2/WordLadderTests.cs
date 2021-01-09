using System.Collections.Generic;
using Training.LeetCode.januari.week2;
using Xunit;

namespace TrainingTests.LeetCode.januari.week2
{
    public class WordLadderTests
    {
        [InlineData(5, "hot", "cog", new string[] {"hot", "dot", "dog", "lot", "log", "cog"})]
        [InlineData(0, "hot", "cog", new string[] { "hot", "dot", "dog", "lot", "log" })]
        [InlineData(0, "hot", "cog", new string[] { "cog", "dot", "dog", "lot", "log", "hot" })]
        [InlineData(5, "hot", "cog", new string[] { "hot", "hot", "dog", "lot", "log", "cog" })]
        [Theory]
        public void WordLadder_Given_ListOfWordsAndStartAndStop_Returns_Length(int expected, string beginWord, string endWord, IList<string> wordList)
        {
            int actual = WordLadder.LadderLength(beginWord, endWord, wordList);

            Assert.Equal(expected, actual);
        }
    }
}
