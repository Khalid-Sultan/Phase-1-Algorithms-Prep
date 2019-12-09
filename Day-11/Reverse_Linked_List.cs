using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class Reverse_Linked_List
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode tempHead = head;
            ListNode tempHead2 = head;
            int counter = 0;
            if (head == null) return null;
            while (tempHead.next != null)
            {
                tempHead = tempHead.next;
                counter++;
            }
            if (tempHead.next == null) counter++;
            int[] collection = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                collection[i] = tempHead2.val;
                tempHead2 = tempHead2.next;
            }
            ListNode cleaned = new ListNode(collection[collection.Length - 1]);
            ListNode cleanedHead = cleaned;
            for (int i = counter - 2; i >= 0; i--)
            {
                cleaned.next = new ListNode(collection[i]);
                cleaned = cleaned.next;
            }
            return cleanedHead;
        }
    }
}
