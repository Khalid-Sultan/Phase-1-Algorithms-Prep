using System;
using System.Collections.Generic;
using System.Text;

namespace Day_38
{
    class Linked_List_Components
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public int NumComponents(ListNode head, int[] G)
        {
            List<int> linked_list = new List<int>();
            while (head != null)
            {
                linked_list.Add(head.val);
                head = head.next;
            }

            HashSet<int> subset = new HashSet<int>();
            foreach(int i in G)
            {
                subset.Add(i);
            }

            int result = 0;
            int temp = 0;
            for (int i = 0; i<linked_list.Count; i++)
            {
                if (subset.Contains(linked_list[i]))
                {
                    temp++;
                    continue;
                }
                if (temp > 0)
                {
                    temp = 0;
                    result++;
                }
            }
            if (temp != 0)
            {
                result++;
            }
            return result;
        }

        //static void Main(string[] args)
        //{

        //}
    }
}
