using System;
using System.Collections.Generic;
using System.Text;

namespace Day_14
{
    class Search_in_a_BST
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;
            if (root.val == val) return root;
            TreeNode left_check = SearchBST(root.left, val);
            TreeNode right_check = SearchBST(root.right, val);
            if (left_check != null && left_check.val == val) return left_check;
            if (right_check != null && right_check.val == val) return right_check;
            return null;
        }
    }
}
