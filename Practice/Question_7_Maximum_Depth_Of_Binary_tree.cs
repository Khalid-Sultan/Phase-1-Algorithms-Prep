using Day_16;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Question_7_Maximum_Depth_Of_Binary_tree
    {
        public int MaxDepth(TreeNode root)
        {
            int max_depth = 0;
            if (root == null)
            {
                return max_depth;
            }


            Stack<ArrayList> values = new Stack<ArrayList>();
            ArrayList ls = new ArrayList();
            ls.Add(root);
            ls.Add(1);
            values.Push(ls);

            while (values.Count > 0)
            {
                ArrayList temp = values.Pop();
                TreeNode temp_node = (TreeNode)temp[0];
                int temp_depth = (int)temp[1];
                max_depth = Math.Max(temp_depth, max_depth);
                if (temp_node.left != null)
                {
                    ArrayList temp_ls = new ArrayList();
                    temp_ls.Add(temp_node.left);
                    temp_ls.Add(temp_depth + 1);
                    values.Push(temp_ls);
                }
                if (temp_node.right != null)
                {
                    ArrayList temp_ls = new ArrayList();
                    temp_ls.Add(temp_node.right);
                    temp_ls.Add(temp_depth + 1);
                    values.Push(temp_ls);
                }
            }
            return max_depth;
        }
    }
}
