using System;
using System.Collections.Generic;
using System.Text;

namespace Day_15
{
    class Binary_Tree_Postorder_Traversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();
            List<int> original = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode currentRoot = stack.Pop();
                original.Add(currentRoot.val);
                if (currentRoot.left != null) stack.Push(currentRoot.left);
                if (currentRoot.right != null) stack.Push(currentRoot.right);
            }
            original.Reverse();
            return original;
        }
    }
}
