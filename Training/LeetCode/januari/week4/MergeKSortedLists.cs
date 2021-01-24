using System.Collections.Generic;

namespace Training.LeetCode.januari.week4
{

    //SUPER UGLY but it works and go accepted!
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
    public static class MergeKSortedLists
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length < 1)
            {
                return null;
            }
            List<int> arr = new List<int>();
            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] == null)
                {
                    continue;
                }
                var noodel = lists[i];
                while (noodel.next != null)
                {
                    arr.Add(noodel.val);
                    noodel = noodel.next;
                }
                arr.Add(noodel.val);
            }
            if (arr.Count < 1)
            {
                return null;
            }
            arr.Sort();
            List<ListNode> nodes = new List<ListNode>();
            for (int i = 0; i < arr.Count; i++)
            {
                nodes.Add(new ListNode(arr[i]));
                if (i != 0 && i != arr.Count)
                {
                    nodes[i - 1].next = nodes[i];
                }
            }
            return nodes[0];
        }
    }
}
