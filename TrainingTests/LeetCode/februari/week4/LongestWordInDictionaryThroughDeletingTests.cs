using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week4;
using Xunit;

namespace TrainingTests.LeetCode.februari.week4
{
    public class LongestWordInDictionaryThroughDeletingTests
    {
        [InlineData("a", "abc", new string[] { "a", "b", "c" })]
        [InlineData("a", "abpcplea", new string[] { "a", "b", "c" })]
        [InlineData("apple", "abpcplea", new string[] { "ale", "apple", "monkey", "plea" })]
        [InlineData("best", "wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "good" })]
        [Theory]
        public void FindLongestWord_Given_StringAndListOFStrings_Returns_LongestWordPossible(string expected, string s, string[] d)
        {
            var actual = LongestWordInDictionaryThroughDeleting.FindLongestWord(s, d);

            Assert.Equal(expected, actual);
        }
    }
}
