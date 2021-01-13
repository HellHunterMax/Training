using System.Collections.Generic;
using System.Linq;
using Training.LeetCode.januari.week2;
using Xunit;

namespace TrainingTests.LeetCode.januari.week2
{
    public class AddTwoLinkedListNumbersTests
    {
        [Theory]
        [InlineData("708", new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 })]
        [InlineData("70401", new int[] { 2, 4, 9 }, new int[] { 5, 6, 4, 9 })]
        public void AddTwoLinkedListNumbers_Given_TwoLL_Returns_Sum(string expected, int[] arr1, int[] arr2)
        {
            //Assemble
            ListNode l1 = CreateListNode(arr1);
            ListNode l2  = CreateListNode(arr2);
            AddTwoLinkedListNumbers sumLL = new AddTwoLinkedListNumbers();

            //Act
            ListNode node = sumLL.AddTwoNumbers(l1, l2);

            string number1 = string.Empty;
            while (node != null)
            {
                number1 += node.val;
                node = node.next;
            }

            //Assert
            Assert.Equal(expected, number1);

        }

        private static ListNode CreateListNode(int[] arr)
        {
            List<ListNode> listNodes = new List<ListNode>();

            for (int i = 0; i < arr.Length; i++)
            {
                listNodes.Add(new ListNode(arr[i]));

            }
            for (int i = 0; i < listNodes.Count - 1; i++)
            {
                listNodes[i].next = listNodes[i + 1];
            }

            return listNodes[0];
        }
    }
}
