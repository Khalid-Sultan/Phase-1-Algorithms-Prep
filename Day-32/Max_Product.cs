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
        static int FindSum(TreeNode node)
        {
            if (node == null)
                return 0;
            node.val += FindSum(node.left) + FindSum(node.right);
            return node.val;
        }
        static int MaxProduct(TreeNode root)
        {
            FindSum(root);

            int total = root.val;
            long maxProductEver = long.MinValue;

            MaxProduct(root, ref maxProductEver, total);

            return (int)((maxProductEver) % (Math.Pow(10, 9) + 7));
        }
        static void MaxProduct(TreeNode node, ref long maxProductEver, int total)
        {
            if (node == null)
                return;

            long product = (long)node.val * (total - node.val);
            maxProductEver = maxProductEver < product ? product : maxProductEver;

            MaxProduct(node.left, ref maxProductEver, total);
            MaxProduct(node.right, ref maxProductEver, total);
        }

    }
}
