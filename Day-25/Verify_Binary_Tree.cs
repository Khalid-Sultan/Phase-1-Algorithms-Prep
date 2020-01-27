using System;
using System.Collections.Generic;
using System.Text;
using static Day_25.Path_Sum;

namespace Day_25
{
    class Verify_Binary_Tree
    {
        public bool IsValidBST(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            long inorder = -1 * long.MaxValue;
            while (stack.Count > 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if (root.val <= inorder)
                {
                    return false;
                }
                inorder = root.val;
                root = root.right;
            }
            return true;
        }
    }
}
