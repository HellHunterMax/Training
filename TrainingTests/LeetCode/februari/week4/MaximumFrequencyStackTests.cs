using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Training.LeetCode.februari.week4;
using Xunit;

namespace TrainingTests.LeetCode.februari.week4
{
    public class MaximumFrequencyStackTests
    {
        [InlineData(new int[] { 3 },new string[] { "Push", "Push", "Push", "Pop" }, new int[] { 1, 2, 3, -1})]
        [InlineData(new int[] { 1 }, new string[] { "Push", "Push", "Push", "Pop" }, new int[] { 1, 1, 3, -1 })]
        [InlineData(new int[] { 3, 2, 1 }, new string[] { "Push", "Push", "Push", "Pop", "Pop", "Pop" }, new int[] { 1, 2, 3, -1, -1, -1 })]
        [InlineData(new int[] { 1, 3 }, new string[] { "Push", "Pop", "Push", "Pop" }, new int[] { 1, -1, 3, -1 })]
        [InlineData(new int[] { 2, 1, 2, 1 }, new string[] { "Push", "Push", "Push", "Push", "Pop", "Pop", "Pop", "Pop" }, new int[] { 1, 1, 2, 2 })]
        [Theory]
        public void FreqStack_Given_Commands_Returns_Ints(int[] expected, string[] commands, int[] numbers)
        {
            FreqStack stack = new FreqStack();
            List<int> actual = new List<int>();

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "Push")
                {
                    stack.Push(numbers[i]);
                }
                else if (commands[i] == "Pop")
                {
                    actual.Add(stack.Pop());
                }
            }

            Assert.Equal(expected.ToList(), actual);
        }
    }
}
