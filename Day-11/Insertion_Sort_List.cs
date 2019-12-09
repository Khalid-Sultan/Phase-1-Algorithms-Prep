using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11
{
    class Insertion_Sort_List
    {
        public ListNode InsertionSortList(ListNode head)
        {
            if (head == null) return null;
            ListNode lastNode = head;
            ListNode returnNode = new ListNode(head.val);
            ListNode returnNodeHead = returnNode;
            head = head.next;
            while (head != null)
            {
                if (head.val <= returnNodeHead.val)
                {
                    ListNode next = returnNodeHead;
                    returnNodeHead = new ListNode(head.val);
                    returnNodeHead.next = next;
                }
                else if (head.val >= lastNode.val)
                {
                    returnNode.next = new ListNode(head.val);
                    returnNode = returnNode.next;
                    lastNode = returnNode;
                }
                else
                {
                    ListNode temp = returnNodeHead;
                    while (temp.val < head.val)
                    {
                        if (temp.next.val > head.val) break;
                        temp = temp.next;
                    }
                    ListNode next = temp.next;
                    ListNode inserted = new ListNode(head.val);
                    inserted.next = next;
                    temp.next = inserted;
                }
                head = head.next;
            }
            return returnNodeHead;
        }
    }
}
