using System;
using System.Collections.Generic;

namespace Day_25
{
    class Max_Depth
    {
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        } 
        public class Solution
        {
            public int MaxDepth(Node root)
            {
                return MaxDepth(root, 1);
            }

            public int MaxDepth(Node root, int depth)
            {
                if (root == null) return depth - 1;
                if (root.children.Count == 0) return depth;
                int fin_dep = depth + 1;
                foreach (Node child in root.children)
                {
                    int current_depth = MaxDepth(child, depth + 1);
                    if (current_depth >= fin_dep)
                    {
                        fin_dep = current_depth;
                    }
                }
                return fin_dep;
            }
        }
    }
}
