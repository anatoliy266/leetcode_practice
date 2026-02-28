/*
 * @lc app=leetcode id=124 lang=csharp
 *
 * [124] Binary Tree Maximum Path Sum
 */

// @lc code=start

using System.Xml;

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
    public int maxSum = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        Dfs(root);
        return maxSum;
    }

    public int Dfs(TreeNode node)
    {
        if (node == null) return 0;

        var L = Math.Max(0, Dfs(node.left));
        var R = Math.Max(0, Dfs(node.right));
        var sum = L+R+node.val;
        maxSum = sum > maxSum ? sum : maxSum;
        return node.val + Math.Max(L,R);
    }
}
// @lc code=end

