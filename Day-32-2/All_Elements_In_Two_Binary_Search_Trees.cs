using System;
using System.Collections.Generic;
using System.Text;

namespace Day_32_2
{
    class All_Elements_In_Two_Binary_Search_Trees
    {
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            List<int> allElements = new List<int>();
            AddElementsToList(root1, allElements);
            AddElementsToList(root2, allElements);
            allElements.Sort();
            return allElements;
        }
        public void AddElementsToList(TreeNode root, List<int> ls)
        {
            if (root == null)
            {
                return;
            }
            ls.Add(root.val);
            if (root.left != null)
            {
                AddElementsToList(root.left, ls);
            }
            if (root.right != null)
            {
                AddElementsToList(root.right, ls);
            }
        }
    }
}
