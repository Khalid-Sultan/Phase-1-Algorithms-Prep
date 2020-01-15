using System;
using System.Collections.Generic;
using System.Text;

namespace Day_24
{
    class Design_Hashmap
    {
        public class MyHashMap
        {

            private int[] array;
            /** Initialize your data structure here. */
            public MyHashMap()
            {
                this.array = new int[1000000];
                for (int i = 0; i < 1000000; i++) array[i] = -1;
            }

            /** value will always be non-negative. */
            public void Put(int key, int value)
            {
                array[key] = value;
            }

            /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
            public int Get(int key)
            {
                return array[key];
            }

            /** Removes the mapping of the specified value key if this map contains a mapping for the key */
            public void Remove(int key)
            {
                array[key] = -1;
            }
        }

        /**
         * Your MyHashMap object will be instantiated and called as such:
         * MyHashMap obj = new MyHashMap();
         * obj.Put(key,value);
         * int param_2 = obj.Get(key);
         * obj.Remove(key);
         */
    }
}
