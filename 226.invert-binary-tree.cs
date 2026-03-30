/*
 * @lc app=leetcode id=226 lang=csharp
 *
 * [226] Invert Binary Tree
 */

// @lc code=start
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
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root is null) return root;
        if (root.left is null && root.right is null)
        {
            return root;
        }
        var left = root.left is not null ? InvertTree(root.left) : root.left;
        var right = root.right is not null ? InvertTree(root.right) : root.right;
        (root.left, root.right) = (right, left);
        return root;
    }
}
// @lc code=end

