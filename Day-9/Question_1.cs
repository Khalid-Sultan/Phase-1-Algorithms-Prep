using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9
{
    public class MyStack
    {
        //     public Queue<int> queue = new Queue<int>();
        //     public Queue<int> backup_queue = new Queue<int>();
        //     public int last_element = 0;

        //     /** Initialize your data structure here. */
        //     public MyStack() { 
        //     }

        //     /** Push element x onto stack. */
        //     public void Push(int x) {
        //         this.queue.Enqueue(x);
        //         last_element = x;
        //     }

        //     /** Removes the element on top of the stack and returns that element. */
        //     public int Pop() {
        //         int returned_element = last_element;
        //         while(queue.Count>1){
        //             backup_queue.Enqueue(queue.Dequeue());
        //         }
        //         queue = backup_queue;  
        //         if(queue.Count>0) last_element = queue.Peek();
        //         else last_element = 0;
        //         return returned_element;
        //     }

        //     /** Get the top element. */
        //     public int Top() {        
        //         return last_element;
        //     }

        //     /** Returns whether the stack is empty. */
        //     public bool Empty() {
        //         return !(queue.Count>0);
        //     }
        Stack<int> stack = new Stack<int>();

        public void Push(int x)
        {
            stack.Push(x);
        }

        public int Pop()
        {
            return stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public bool Empty()
        {
            return stack.Count > 0 ? false : true;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}
