using System;
using System.Collections.Generic;
using System.Text;

namespace Day_14
{
    class Same_Tree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if ((p == null && q != null) || (p != null && q == null) || (p != null && q != null && p.val != q.val)) return false;
            bool left_section = (p == null && q == null) ? true : IsSameTree(p.left, q.left);
            bool right_section = (p == null && q == null) ? true : IsSameTree(p.right, q.right);
            if (left_section == true && right_section == true) return true;
            return false;
        }
    }
}
