using System;
using System.Collections.Generic;
using System.Text;

namespace Day_34
{
    class Distribute_Coins
    {
        static void Main(string[] args)
        {
            TreeNode treeNode = new TreeNode(3);
            treeNode.left = new TreeNode(0);
            treeNode.right = new TreeNode(0);
            Console.WriteLine(DistributeCoins(treeNode));
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        static int DistributeCoins(TreeNode root)
        {
            int result = 0;
            if (root == null)
            {
                return result;
            }
            result = DistributeFromTopDown(root);
            return result;
        }

        static int moves = 0;
        static int DistributeFromTopDown(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = DistributeFromTopDown(root.left);
            int right = DistributeFromTopDown(root.right);
            moves += Math.Abs(left) + Math.Abs(right);
            int result = left + right + root.val - 1;
            return result;
        }
    }
}
