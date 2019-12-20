using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16
{
    class Minimum_Distance_Between_BST_Nodes
    {
        public int MinDiffInBST(TreeNode root)
        {
            Stack<TreeNode> nodes = new Stack<TreeNode>();
            nodes.Push(root);
            List<int> values = new List<int>();
            while (nodes.Count > 0)
            {
                TreeNode popped = nodes.Pop();
                values.Add(popped.val);
                if (popped.left != null) nodes.Push(popped.left);
                if (popped.right != null) nodes.Push(popped.right);
            }
            if (values.Count == 1) return values[0];
            int min = System.Math.Abs(values[0] - values[1]);
            for (int i = 0; i < values.Count; i++)
            {
                int a = values[i];
                for (int j = 0; j < values.Count; j++)
                {
                    if (i == j) continue;
                    int b = values[j];
                    if (System.Math.Abs(a - b) < min) min = System.Math.Abs(a - b);
                }
            }
            return min;
        }
    }
}
