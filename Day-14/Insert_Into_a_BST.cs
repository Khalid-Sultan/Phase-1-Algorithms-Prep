using System;
using System.Collections.Generic;
using System.Text;

namespace Day_14
{
    class Insert_Into_a_BST
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (val < root.val)
            {
                if (root.left != null) InsertIntoBST(root.left, val);
                else root.left = new TreeNode(val);
            }
            else
            {
                if (root.right != null) InsertIntoBST(root.right, val);
                else root.right = new TreeNode(val);
            }
            return root;
        }
    }
}
