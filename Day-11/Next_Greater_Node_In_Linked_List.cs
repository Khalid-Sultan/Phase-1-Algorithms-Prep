using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11
{
    class Next_Greater_Node_In_Linked_List
    {
        public int[] NextLargerNodes(ListNode head)
        {
            ListNode temp = head;
            List<int> values = new List<int>();
            while (temp != null)
            {
                values.Add(temp.val);
                temp = temp.next;
            }
            int[] results = new int[values.Count];

            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> min_pairs = new Dictionary<int, int>();
            int i = 0;
            while (i < values.Count)
            {
                while (stack.Count > 0 && values[stack.Peek()] < values[i])
                {
                    min_pairs.Add(stack.Pop(), values[i]);
                }
                stack.Push(i);
                i++;
            }
            for (int counter = 0; counter < values.Count; counter++)
            {
                results[counter] = min_pairs.GetValueOrDefault(counter, 0);
            }
            return results;

        }
    }
}
