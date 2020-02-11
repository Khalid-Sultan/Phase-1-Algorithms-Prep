using System;
using System.Collections.Generic;
using System.Text;

namespace Day_32
{
    class Max_Product
    {
        class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        static int findSum(TreeNode root, int sum)
        {
            if(root.left==null && root.right == null)
            {
                return root.val;
            }
            if (root.left != null)
            {
                sum += findSum(root.left, sum);
            }
            if (root.right != null)
            {
                sum += findSum(root.right, sum);
            }
            return sum;
        }
        static int MaxProduct(TreeNode root)
        {
            int currentMax = findSum(root, 0);
            if (root.left == null && root.right == null)
            {
                return currentMax;
            }
            return MaxProduct(root,currentMax,currentMax) % Convert.ToInt32(Math.Pow(Convert.ToDouble(10),Convert.ToDouble(9))+7);
        }
        static int MaxProduct(TreeNode root, int rootSum, int maxProduct)
        {
            if(root.left==null && root.right == null)
            {
                return maxProduct;
            }
            if (root.left != null)
            {
                int currentSum = findSum(root.left, 0);
                if (maxProduct < currentSum * (rootSum - currentSum))
                {
                    maxProduct = currentSum * (rootSum - currentSum);
                }
                maxProduct = MaxProduct(root.left, rootSum, maxProduct);
            }
            if (root.right != null)
            {
                int currentSum = findSum(root.right, 0);
                if (maxProduct < currentSum * (rootSum - currentSum))
                {
                    maxProduct = currentSum * (rootSum - currentSum);
                }
                maxProduct = MaxProduct(root.left, rootSum, maxProduct);
            }
            return maxProduct;
        }

    }
}
