using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12
{
    class Design_Circular_Deque
    {
        public class MyCircularDeque
        {
            List<int> deque = new List<int>();
            /** Initialize your data structure here. Set the size of the deque to be k. */
            public MyCircularDeque(int k)
            {
                deque.Capacity = k;
            }

            /** Adds an item at the front of Deque. Return true if the operation is successful. */
            public bool InsertFront(int value)
            {
                if (IsFull()) return false;
                deque.Insert(0, value);
                return true;
            }

            /** Adds an item at the rear of Deque. Return true if the operation is successful. */
            public bool InsertLast(int value)
            {
                if (IsFull()) return false;
                deque.Insert(deque.Count, value);
                return true;
            }

            /** Deletes an item from the front of Deque. Return true if the operation is successful. */
            public bool DeleteFront()
            {
                if (IsEmpty()) return false;
                deque.RemoveAt(0);
                return true;
            }

            /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
            public bool DeleteLast()
            {
                if (IsEmpty()) return false;
                deque.RemoveAt(deque.Count - 1);
                return true;
            }

            /** Get the front item from the deque. */
            public int GetFront()
            {
                if (IsEmpty()) return -1;
                return deque[0];
            }

            /** Get the last item from the deque. */
            public int GetRear()
            {
                if (IsEmpty()) return -1;
                return deque[deque.Count - 1];
            }

            /** Checks whether the circular deque is empty or not. */
            public bool IsEmpty()
            {
                return deque.Count == 0;
            }

            /** Checks whether the circular deque is full or not. */
            public bool IsFull()
            {
                return deque.Count == deque.Capacity;
            }
        }

        /**
         * Your MyCircularDeque object will be instantiated and called as such:
         * MyCircularDeque obj = new MyCircularDeque(k);
         * bool param_1 = obj.InsertFront(value);
         * bool param_2 = obj.InsertLast(value);
         * bool param_3 = obj.DeleteFront();
         * bool param_4 = obj.DeleteLast();
         * int param_5 = obj.GetFront();
         * int param_6 = obj.GetRear();
         * bool param_7 = obj.IsEmpty();
         * bool param_8 = obj.IsFull();
         */
    }
}
