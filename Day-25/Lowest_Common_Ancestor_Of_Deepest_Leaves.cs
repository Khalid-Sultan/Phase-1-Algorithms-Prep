using System;
using System.Collections.Generic;
using System.Text;
using static Day_25.Path_Sum;

namespace Day_25
{
    class Lowest_Common_Ancestor_Of_Deepest_Leaves
    {
        TreeNode ancestor = null;
        int max_depth = 0;
        public TreeNode LcaDeepestLeaves(TreeNode root)
        {
            int depth = 0;
            if (root != null)
                Traverse(root, depth);
            return ancestor;
        }
        public int Traverse(TreeNode root, int depth)
        {
            if (root == null)
            {
                return 0;
            }
            int left_depth = Traverse(root.left, depth + 1);
            int right_depth = Traverse(root.right, depth + 1);
            if (left_depth == right_depth)
            {
                if (depth + left_depth >= max_depth)
                {
                    max_depth = depth + left_depth;
                    ancestor = root;
                }
            }
            if (left_depth >= right_depth)
            {
                return left_depth + 1;
            }
            return right_depth + 1;
        }
    }
}
