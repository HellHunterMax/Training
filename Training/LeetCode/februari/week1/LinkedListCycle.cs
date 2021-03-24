using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week1
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x)
        {
            val = x;
            next = null;
                 }
  }
    public static class LinkedListCycle
    {
        public static bool HasCycle(ListNode head)
        {
            return FirstTry(head);
        }

        public static bool FirstTry(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            ListNode node = head;
            List<ListNode> listOfNodes = new List<ListNode>();
            while (node.next != null)
            {
                listOfNodes.Add(node);
                if (listOfNodes.Contains(node.next))
                {
                    return true;
                }
                node = node.next;
            }
            return false;
        }

        public static bool Speedup(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            ListNode node = head;
            HashSet<ListNode> listOfNodes = new HashSet<ListNode>();
            while (node.next != null)
            {
                listOfNodes.Add(node);
                if (listOfNodes.Contains(node.next))
                {
                    return true;
                }
                node = node.next;
            }

            return false;
        }
    }
}
