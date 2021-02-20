using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Training.LeetCode.februari.week3;
using System.Linq;

namespace TrainingTests.LeetCode.februari.week3
{
    public class MinimumRemoveToMakeValidParenthesesTests
    {
        [InlineData(new string[] { "" }, ")(")]
        [InlineData(new string[] { "" }, "))((")]
        [InlineData(new string[] {"lee(t(co)de)", "lee(t(c)ode)", "lee(t(c)o)de" }, "lee(t(c)o)de)")]
        [InlineData(new string[] { "ab(c)d" }, "a)b(c)d")]
        [InlineData(new string[] { "a(b(c)d)", "(ab(c)d)", "(a(bc)d)" }, "(a(b(c)d)")]

        [Theory]
        public void MinimumRemoveToMakeValidParentheses_Given_String_Returns_StringWithValidParentheses(string[] expected, string s)
        {
            var actual = MinimumRemoveToMakeValidParentheses.MinRemoveToMakeValid(s);

            Assert.Contains(actual, expected);
        }
    }
}
