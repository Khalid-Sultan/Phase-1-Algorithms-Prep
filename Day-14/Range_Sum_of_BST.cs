using System;
using System.Collections.Generic;
using System.Text;

namespace Day_14
{
    class Range_Sum_of_BST
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            int result = 0;
            if (root != null && root.val <= R && root.val >= L)
            {
                result += root.val;
            }
            if (root != null)
            {
                TreeNode left = root.left;
                TreeNode right = root.right;
                result += RangeSumBST(left, L, R);
                result += RangeSumBST(right, L, R);
            }
            return result;
        }
    }
}
