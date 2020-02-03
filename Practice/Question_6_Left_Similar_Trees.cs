using Day_16;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Question_6_Left_Similar_Trees
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> root1_leaves = new List<int>(), root2_leaves = new List<int>();

            DFS(root1, root1_leaves);
            DFS(root2, root2_leaves);

            if (root1_leaves.Count == root2_leaves.Count)
            {
                for (int i = 0; i < root1_leaves.Count; i++)
                {
                    if (root1_leaves[i] == root2_leaves[i])
                    {
                        continue;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }

        public void DFS(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            if (root.left != null)
            {
                DFS(root.left, list);
            }
            if (root.right != null)
            {
                DFS(root.right, list);
            }
            if (root.left == null && root.right == null)
            {
                list.Add(root.val);
            }
        }
    }
}
