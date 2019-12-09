using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11
{
    class Remove_Duplicates_from_Sorted_List
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            ListNode duplicate_cleaned = new ListNode(head.val);
            duplicate_cleaned.next = null;
            ListNode duplicate_head = duplicate_cleaned;
            while (head != null)
            {
                if (duplicate_cleaned.val != head.val)
                {
                    duplicate_cleaned.next = new ListNode(head.val);
                    duplicate_cleaned = duplicate_cleaned.next;
                    duplicate_cleaned.next = null;
                }
                head = head.next;
            }
            return duplicate_head;
        }
    }
}
