/*
 * @lc app=leetcode id=98 lang=csharp
 *
 * [98] Validate Binary Search Tree
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
    public int value = int.MinValue;
    private bool isFirstNode = true;
    public bool IsValidBST(TreeNode root) {
        if (root == null) return true;
        
        if (!IsValidBST(root.left)) return false;
        if (!isFirstNode && root.val <= value) return false;
        isFirstNode = false;
        value = root.val;
        return IsValidBST(root.right);
    }
}
// @lc code=end

