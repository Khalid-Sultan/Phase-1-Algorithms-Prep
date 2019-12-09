using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11
{
    class Merge_Two_Sorted_Lists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode mergedList;
            ListNode head;
            if (l1 == null && l2 == null)
            {
                mergedList = null;
                head = mergedList;
            }
            else if (l1 == null)
            {
                mergedList = new ListNode(l2.val);
                head = mergedList;
                l2 = l2.next;
            }
            else if (l2 == null)
            {
                mergedList = new ListNode(l1.val);
                head = mergedList;
                l1 = l1.next;
            }
            else if (l1.val < l2.val)
            {
                mergedList = new ListNode(l1.val);
                head = mergedList;
                l1 = l1.next;
            }
            else if (l1.val > l2.val)
            {
                mergedList = new ListNode(l2.val);
                head = mergedList;
                l2 = l2.next;
            }
            else
            {
                mergedList = new ListNode(l1.val);
                head = mergedList;
                mergedList.next = new ListNode(l2.val);
                mergedList = mergedList.next;
                l1 = l1.next;
                l2 = l2.next;
            }
            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    mergedList.next = new ListNode(l2.val);
                    mergedList = mergedList.next;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    mergedList.next = new ListNode(l1.val);
                    mergedList = mergedList.next;
                    l1 = l1.next;
                }
                else if (l1.val < l2.val)
                {
                    mergedList.next = new ListNode(l1.val);
                    mergedList = mergedList.next;
                    l1 = l1.next;
                }
                else if (l1.val > l2.val)
                {
                    mergedList.next = new ListNode(l2.val);
                    mergedList = mergedList.next;
                    l2 = l2.next;
                }
                else
                {
                    mergedList.next = new ListNode(l1.val);
                    mergedList = mergedList.next;
                    l1 = l1.next;
                    mergedList.next = new ListNode(l2.val);
                    mergedList = mergedList.next;
                    l2 = l2.next;
                }
            }
            return head;
        }
    }
}
