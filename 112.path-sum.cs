/*
 * @lc app=leetcode id=112 lang=csharp
 *
 * [112] Path Sum
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
public class Solution
{
    public bool res = false;
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null) return res;
        if (root.left == null && root.right == null)
        {
            return targetSum == root.val;
        }
        return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
        
        // if (root == null) return res;
        // Dfs(root, root.val, targetSum);
        // return res;
    }

    // public void Dfs(TreeNode root, int currSum, int targetSum)
    // {
    //     if (root.left == null && root.right == null)
    //     {
    //         if (currSum == targetSum) res = true;
    //     }
    //     else
    //     {
    //         if (root.left != null) Dfs(root.left, currSum+root.left.val, targetSum);
    //         if (root.right != null) Dfs(root.right, currSum+root.right.val, targetSum);
    //     }
    // }
}
// @lc code=end

