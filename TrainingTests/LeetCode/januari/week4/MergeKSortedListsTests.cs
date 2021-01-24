using System.Collections.Generic;
using System.Linq;
using Training.LeetCode.januari.week4;
using Xunit;

namespace TrainingTests.LeetCode.januari.week4
{
    public class MergeKSortedListsTests
    {
        [Fact]
        public void MergeKSortedLists_Given_MiltipleLists_Returns_1SortedList()
        {
            int[] arr = new int[] { 1, 1, 2, 3, 4, 4, 5, 6 };
            List<ListNode> expected = new List<ListNode>();
            for (int i = 0; i < arr.Length; i++)
            {
                expected.Add(new ListNode(arr[i]));
                if (i != 0 && i != arr.Length)
                {
                    expected[i - 1].next = expected[i];
                }
            }
            int[] arr1 = new int[] { 1, 4, 5 };
            List<ListNode> imput1 = new List<ListNode>();
            for (int i = 0; i < arr1.Length; i++)
            {
                imput1.Add(new ListNode(arr1[i]));
                if (i != 0 && i != arr1.Length)
                {
                    imput1[i - 1].next = imput1[i];
                }
            }
            int[] arr2 = new int[] { 1, 3, 4 };
            List<ListNode> imput2 = new List<ListNode>();
            for (int i = 0; i < arr2.Length; i++)
            {
                imput2.Add(new ListNode(arr2[i]));
                if (i != 0 && i != arr2.Length)
                {
                    imput2[i - 1].next = imput2[i];
                }
            }
            int[] arr3 = new int[] { 2, 6 };
            List<ListNode> imput3 = new List<ListNode>();
            for (int i = 0; i < arr3.Length; i++)
            {
                imput3.Add(new ListNode(arr3[i]));
                if (i != 0 && i != arr3.Length)
                {
                    imput3[i - 1].next = imput3[i];
                }
            }
            ListNode[] finalImput = new ListNode[] { imput1[0], imput2[0], imput3[0] };

            var action1 = MergeKSortedLists.MergeKLists(finalImput);

            List<int> actual = new List<int>();

            while (action1.next != null)
            {
                actual.Add(action1.val);
                action1 = action1.next;
            }
            actual.Add(action1.val);

            Assert.Equal(arr.ToList(), actual);
        }
        [Fact]
        public void MergeKSortedLists_Given_emptyLists_Returns_1SortedList()
        {
            ListNode[] finalImput = new ListNode[] { null };

            var action1 = MergeKSortedLists.MergeKLists(finalImput);

            var actual = new List<int>();

            Assert.Equal(null, action1);
        }
        [Fact]
        public void MergeKSortedLists_Given_emptyListsAndFilledList_Returns_1SortedList()
        {
            int[] arr = new int[] { 1 };

            List<ListNode> imput2 = new List<ListNode>()
            { new ListNode(1)};

            ListNode[] finalImput = new ListNode[] { null, imput2[0] };

            var action1 = MergeKSortedLists.MergeKLists(finalImput);

            List<int> actual = new List<int>();

            while (action1.next != null)
            {
                actual.Add(action1.val);
                action1 = action1.next;
            }
            actual.Add(action1.val);

            Assert.Equal(arr.ToList(), actual);
        }

    }
}
