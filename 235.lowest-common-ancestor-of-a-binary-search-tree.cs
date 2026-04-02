/*
 * @lc app=leetcode id=235 lang=csharp
 *
 * [235] Lowest Common Ancestor of a Binary Search Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root is null) return root;
        if (p.val < root.val && q.val < root.val) return LowestCommonAncestor(root.left, p, q);  
        else if (p.val > root.val && q.val > root.val) return LowestCommonAncestor(root.right, p, q);
        else return root;
    }
}
// @lc code=end

