/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int sum = 0;
        int carry = 0;
        ListNode currentNode = new ListNode(0);
        ListNode currentNodeHead = currentNode;
        while (l1 != null || l2 != null)
        {
            int a = l1 != null ? l1.val : 0;
            int b = l2 != null ? l2.val : 0;

            sum = carry + a + b;
            carry = sum / 10;

            sum = sum % 10;

            currentNode.next = new ListNode(sum);
            currentNode = currentNode.next;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }
        if (carry > 0)
        {
            currentNode.next = new ListNode(carry);
        }
        return currentNodeHead.next;
    }
}