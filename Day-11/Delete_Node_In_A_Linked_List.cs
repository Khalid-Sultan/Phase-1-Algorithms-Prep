using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11
{
    class Delete_Node_In_A_Linked_List
    {
        public void DeleteNode(ListNode node)
        {
            ListNode replacement = node.next;
            if (replacement == null) node = null;
            else
            {
                node.val = replacement.val;
                node.next = replacement.next;
            }
        }
    }
}
