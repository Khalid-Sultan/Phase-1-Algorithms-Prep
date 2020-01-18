using System;
using System.Collections.Generic;
using System.Text;

namespace Day_25
{
    class Path_Sum
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root != null)
            {
                return CheckPathSum(root, root.val, sum);
            }
            return false;
        }
        public bool CheckPathSum(TreeNode root, int prev_sum, int sum)
        {
            if (root.left == null && root.right == null && prev_sum == sum)
            {
                return true;
            }
            if (root == null)
            {
                if (prev_sum == sum)
                {
                    return true;
                }
                return false;
            }
            if (root.left != null)
            {
                if (CheckPathSum(root.left, prev_sum + root.left.val, sum))
                {
                    return true;
                }
            }
            if (root.right != null)
            {
                if (CheckPathSum(root.right, prev_sum + root.right.val, sum))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
