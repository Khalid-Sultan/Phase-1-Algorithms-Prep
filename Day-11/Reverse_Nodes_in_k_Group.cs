using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11
{
    class Reverse_Nodes_in_k_Group
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null) return null;
            ListNode returnHead = null;
            ListNode tempHead = head;

            while (tempHead != null)
            {
                int counter = 0;
                ListNode currentNode = tempHead;
                ListNode prevNode = null;
                while (currentNode != null)
                {
                    if (counter == k) break;
                    counter++;

                    ListNode t = new ListNode(currentNode.val);
                    t.next = prevNode;
                    prevNode = t;


                    currentNode = currentNode.next;

                }
                if (counter == k)
                {
                    while (prevNode != null)
                    {
                        ListNode t = new ListNode(prevNode.val);
                        t.next = returnHead;
                        returnHead = t;
                        tempHead = tempHead.next;
                        prevNode = prevNode.next;
                    }
                }
                else
                {
                    while (tempHead != null)
                    {
                        ListNode t = new ListNode(tempHead.val);
                        t.next = returnHead;
                        returnHead = t;
                        tempHead = tempHead.next;
                    }
                    break;
                }
            }

            ListNode final_result = new ListNode(returnHead.val);
            ListNode dummyHead = final_result;
            returnHead = returnHead.next;

            while (returnHead != null)
            {
                ListNode temp = new ListNode(returnHead.val);
                temp.next = dummyHead;
                dummyHead = temp;
                returnHead = returnHead.next;
            }
            return dummyHead;
        }
    }
}
