using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Day_15
{
    class Maxium_Binary_Tree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            if (nums.Length == 0) return null;

            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > nums[max]) max = i;
            }
            TreeNode root = new TreeNode(nums[max]);
            if (nums.Length == 1) return root;

            int[] smallerArray = new int[max];
            int[] largerArray = new int[nums.Length - max - 1];
            for (int i = 0; i < max; i++)
            {
                smallerArray[i] = nums[i];
            }
            for (int i = 0; i < nums.Length - max - 1; i++)
            {
                largerArray[i] = nums[max + i + 1];
            }
            root.left = ConstructMaximumBinaryTree(smallerArray);
            root.right = ConstructMaximumBinaryTree(largerArray);
            return root;
        }
    }
}
