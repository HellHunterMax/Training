using Xunit;
using Training.LeetCode.januari.week2;

namespace TrainingTests.LeetCode.januari.week2
{
    public class MergeSortedArrayTests
    {
        [InlineData(new int[] { 1, 2, 2, 3, 5, 6 },new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3)]
        [InlineData(new int[] { 1 }, new int[] { 1 }, 1, new int[] { }, 0)]
        [Theory]
        public void MergeSortedArray_Given_TwoArraysAndLength_MergesAndSorts(int[] expected, int[] nums1, int m, int[] nums2, int n)
        {
            MergeSortedArray mergeSortedArray = new MergeSortedArray();

            var actual = mergeSortedArray.Merge(nums1, m, nums2 , n);

            Assert.Equal(expected, actual);
        }
    }
}
