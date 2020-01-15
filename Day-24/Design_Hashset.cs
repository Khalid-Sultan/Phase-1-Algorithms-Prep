using System;
using System.Collections.Generic;
using System.Text;

namespace Day_24
{
    class Design_Hashset
    {
        public class MyHashSet
        {

            private List<int> list;
            /** Initialize your data structure here. */
            public MyHashSet()
            {
                this.list = new List<int>();
            }

            public void Add(int key)
            {
                this.list.Add(key);
            }

            public void Remove(int key)
            {
                this.list.RemoveAll(x => x == key);
            }

            /** Returns true if this set contains the specified element */
            public bool Contains(int key)
            {
                return this.list.Contains(key);
            }
        }

        /**
         * Your MyHashSet object will be instantiated and called as such:
         * MyHashSet obj = new MyHashSet();
         * obj.Add(key);
         * obj.Remove(key);
         * bool param_3 = obj.Contains(key);
         */
    }
}
