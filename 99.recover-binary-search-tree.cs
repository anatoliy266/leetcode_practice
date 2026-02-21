/*
 * @lc app=leetcode id=99 lang=csharp
 *
 * [99] Recover Binary Search Tree
 */

// @lc code=start

using System.ComponentModel.Design.Serialization;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public void RecoverTree(TreeNode root)
    {
        TreeNode first = null, second = null;
        var stack = new Stack<TreeNode>();
        TreeNode prev = null;
        while (root != null || stack.Count  > 0)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            if (prev != null && first == null && root.val < prev.val)
            {
                first = prev;
                second = root;
            }

            if (prev != null && root.val < prev.val)
            {
                second = root;
            }
            prev = root;
            root = root.right;
        }

        (first.val, second.val) = (second.val, first.val);
    }
}
// @lc code=end




