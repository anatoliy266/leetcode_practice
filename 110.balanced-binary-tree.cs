/*
 * @lc app=leetcode id=110 lang=csharp
 *
 * [110] Balanced Binary Tree
 */

// @lc code=start

using System.Security.AccessControl;
using Microsoft.VisualBasic;

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
    public bool IsBalanced(TreeNode root) {
        var (d,res) = Dfs(root, 0);
        return res;
    }

    public (int, bool) Dfs(TreeNode root, int depth)
    {
        if (root == null) return (depth+1,true);
        var (depthL, left) = Dfs(root.left, depth);
        var (depthR,right) = Dfs(root.right, depth);
        if (!left || !right || Math.Abs(depthR-depthL) > 1) return (Math.Max(depthL, depthR)+1, false);
        return (Math.Max(depthL, depthR)+1, true);
    }
}
// @lc code=end

