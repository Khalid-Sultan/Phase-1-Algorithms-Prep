using System;
using System.Collections.Generic;
using System.Text;

namespace Day_19
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Merge_K_Sorted_Lists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0) return null;
            List<int> list = new List<int>();
            foreach (ListNode l in lists)
            {
                ListNode temp = l;
                while (temp != null)
                {
                    list.Add(temp.val);
                    temp = temp.next;
                }
            }
            if (list.Count == 0) return null;
            list.Sort();
            ListNode dummyHead = new ListNode(list[0]);
            ListNode head = dummyHead;
            list.RemoveAt(0);
            while (list.Count > 0)
            {
                dummyHead.next = new ListNode(list[0]);
                list.RemoveAt(0);
                dummyHead = dummyHead.next;
            }
            return head;
        }

    }
}
