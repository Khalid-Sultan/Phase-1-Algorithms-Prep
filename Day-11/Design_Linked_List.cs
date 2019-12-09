using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11
{
    class Design_Linked_List
    {
        public class MyLinkedList
        {
            List<int> list = new List<int>();

            /** Initialize your data structure here. */
            public MyLinkedList()
            {
            }

            /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
            public int Get(int index)
            {
                if (index >= list.Count) return -1;
                return list[index];
            }

            /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
            public void AddAtHead(int val)
            {
                list.Insert(0, val);
            }

            /** Append a node of value val to the last element of the linked list. */
            public void AddAtTail(int val)
            {
                list.Insert(list.Count, val);
            }

            /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
            public void AddAtIndex(int index, int val)
            {
                if (index == list.Count) AddAtTail(val);
                else if (index < list.Count)
                    list.Insert(index, val);
            }

            /** Delete the index-th node in the linked list, if the index is valid. */
            public void DeleteAtIndex(int index)
            {
                if (index < list.Count)
                    list.RemoveAt(index);
            }
        }

        /**
         * Your MyLinkedList object will be instantiated and called as such:
         * MyLinkedList obj = new MyLinkedList();
         * int param_1 = obj.Get(index);
         * obj.AddAtHead(val);
         * obj.AddAtTail(val);
         * obj.AddAtIndex(index,val);
         * obj.DeleteAtIndex(index);
         */
    }
}
