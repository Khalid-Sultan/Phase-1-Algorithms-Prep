using System;
using System.Collections.Generic;
using System.Text;

namespace Day_14
{
    class Lowest_Common_Ancestor_in_a_BST
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;
            TreeNode ancestor = root;
            //Continue on left side
            if (p.val < root.val)
            {
                if (q.val < root.val) return LowestCommonAncestor(root.left, p, q);
            }
            //Continue on right side
            else if (p.val > root.val)
            {
                if (q.val > root.val) return LowestCommonAncestor(root.right, p, q);
            }

            return ancestor;
        }
    }
}
