using System;
using System.Collections.Generic;
using System.Text;

namespace Day_14
{
    class Construct_BST_from_Preorder_Traversal
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            TreeNode root = new TreeNode(preorder[0]);
            for (int i = 1; i < preorder.Length; i++)
            {
                int currentElement = preorder[i];
                if (currentElement <= root.val)
                {
                    if (root.left == null)
                        root.left = new TreeNode(currentElement);
                    else
                        root.left = BstFromPreorder(root.left, currentElement);
                }
                else
                {
                    if (root.right == null)
                        root.right = new TreeNode(currentElement);
                    else
                        root.right = BstFromPreorder(root.right, currentElement);
                }
            }
            return root;
        }
        public TreeNode BstFromPreorder(TreeNode root, int currentElement)
        {
            if (currentElement <= root.val)
            {
                if (root.left == null)
                    root.left = new TreeNode(currentElement);
                else
                    root.left = BstFromPreorder(root.left, currentElement);
            }
            else
            {
                if (root.right == null)
                    root.right = new TreeNode(currentElement);
                else
                    root.right = BstFromPreorder(root.right, currentElement);
            }
            return root;
        }
    }
}
