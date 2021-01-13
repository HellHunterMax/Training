using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.januari.week2
{
    //https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/580/week-2-january-8th-january-14th/3601/

    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class AddTwoLinkedListNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string number1 = string.Empty;
            string number2 = string.Empty;

            while (l1 != null)
            {
                number1 += l1.val;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                number2 += l2.val;
                l2 = l2.next;
            }
            string sum = ((int.Parse(number1)) + (int.Parse(number2))).ToString();

            List<ListNode> listOfNodes = new List<ListNode>();

            for (int i = sum.Length - 1; i >= 0; i--)
            {
                listOfNodes.Add(new ListNode(int.Parse(sum[i].ToString())));

            }
            for (int i = 0; i < listOfNodes.Count - 1; i++)
            {
                listOfNodes[i].next = listOfNodes[i + 1];
            }

            return listOfNodes[0];
        }
    }
}
