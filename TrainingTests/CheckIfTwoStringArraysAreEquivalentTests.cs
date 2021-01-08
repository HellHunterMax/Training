using Training.januari.week2;
using Xunit;

namespace TrainingTests
{
    public class CheckIfTwoStringArraysAreEquivalentTests
    {
        [InlineData(new string[] { "ab", "c"}, new string[] { "a" ,"bc" }, true)]
        [InlineData(new string[] { "ab", "c" , "" }, new string[] { "a", "bc" }, true)]
        [InlineData(new string[] { "ab", "c" }, new string[] { "a", "c" }, false)]
        [InlineData(new string[] { "ab", "c", "c" }, new string[] { "a", "bcc" }, true)]
        [Theory(DisplayName ="Two Array's return equal or not")]
        public void ArrayStringsAreEqual_Given_TwoArrays_Returns_EqualOrNot(string[] a, string[] b, bool expected)
        {
            bool result = CheckIfTwoStringArraysAreEquivalent.ArrayStringsAreEqual(a, b);

            Assert.Equal(expected, result);
        }
    }
}
