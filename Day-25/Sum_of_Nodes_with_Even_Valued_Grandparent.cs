using System;
using System.Collections.Generic;
using System.Text;

namespace Day_25
{
    class Sum_of_Nodes_with_Even_Valued_Grandparent
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public int SumEvenGrandparent(TreeNode root)
        {
            int result = 0;
            if (root != null)
            {
                result += SumEvenGrandparent(root, result);
            }
            return result;
        }
        public int SumEvenGrandparent(TreeNode root, int result)
        {
            if (root.val % 2 == 0)
            {
                if (root.left != null)
                {
                    if (root.left.left != null)
                    {
                        result += root.left.left.val;
                    }
                    if (root.left.right != null)
                    {
                        result += root.left.right.val;
                    }
                }
                if (root.right != null)
                {
                    if (root.right.left != null)
                    {
                        result += root.right.left.val;
                    }
                    if (root.right.right != null)
                    {
                        result += root.right.right.val;
                    }
                }
            }
            if (root.left != null)
            {
                result = SumEvenGrandparent(root.left, result);
            }

            if (root.right != null)
            {
                result = SumEvenGrandparent(root.right, result);
            }
            return result;
        }
    }
}
