using System;
using System.Collections.Generic;
using System.Text;

namespace Day_30
{
    class Bitwise
    {
        public static int SubarrayBitwiseORs(int[] A)
        {
            HashSet<int> result = new HashSet<int>();
            HashSet<int> temp_1 = new HashSet<int>();
            
            foreach(int i in A)
            {
                HashSet<int> temp_2 = new HashSet<int>();
                temp_2.Add(i);
                foreach(int j in temp_1)
                {
                    temp_2.Add(i | j);
                }
                foreach(int j in temp_2)
                {
                    result.Add(j);
                }
                temp_1 = temp_2;
            }
            return result.Count;

        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(SubarrayBitwiseORs(new int[] { 0 }));
        //    Console.WriteLine(SubarrayBitwiseORs(new int[] { 1,1,2}));
        //    Console.WriteLine(SubarrayBitwiseORs(new int[] { 1,2,4 }));
        //}



        /*
            void bfs(Node node) {
                queue<Node> que;
                que.insert(node);
                Visit[node.id] = true;
                while(!que.isEmpty()) {
		                Node curr = que.front();
		                que.pop();
		                for(Node child : curr.children) {
	                if(!visited[child.id]) {
	                que.push(child);
	                visited[child.id] = true;
                }
                }
                }
            }

         */

    }
}
