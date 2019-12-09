using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11
{
    class Swap_Nodes_in_Pairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            ListNode node = head;
            head = node.next;
            ListNode prevNode = null;
            while (node != null)
            {
                ListNode nextPair = null;
                if (node.next != null)
                {
                    nextPair = node.next.next;
                    ListNode nextNode = node.next;
                    ListNode nextNextNode = nextNode.next;
                    node.next = nextNextNode;
                    nextNode.next = node;
                    node = nextNode;
                }
                if (prevNode != null) prevNode.next = node;
                prevNode = node.next;
                node = nextPair;
            }
            return head;
        }
    }
}
