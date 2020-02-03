using Day_16;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_30
{
    class InOrder
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root != null)
            {
                DFS(root, list);
            }
            TreeNode result = new TreeNode(-1);
            TreeNode head = result;
            foreach (int i in list)
            {
                head.right = new TreeNode(i);
                head = head.right;
            }
            return result.right;
        }
        public void DFS(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            if (root.left != null)
            {
                DFS(root.left, list);
            }
            list.Add(root.val);

            if (root.right != null)
            {
                DFS(root.right, list);
            }
        }

    }
}
