using System;
using System.Collections.Generic;
using System.Text;

namespace Day_14
{
    class Merge_Two_Binary_Trees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            TreeNode result = t1;
            if (t1 == null)
            {
                return t2;
            }
            else if (t2 == null)
            {
                return t1;
            }
            result.val += t2.val;
            result.left = MergeTrees(t1.left, t2.left);
            result.right = MergeTrees(t1.right, t2.right);
            return result;
        }
    }
}
