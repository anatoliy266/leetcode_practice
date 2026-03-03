/*
 * @lc app=leetcode id=129 lang=csharp
 *
 * [129] Sum Root to Leaf Numbers
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
    public int SumNumbers(TreeNode root) {
        return Dfs(root, 0);
    }

    public int Dfs(TreeNode root, int currentSum)
    {
        if (root == null) return 0;
        currentSum = currentSum * 10 + root.val;
        if (root.left == null && root.right == null)
        {
            return currentSum;
        }
        return Dfs(root.left, currentSum) + Dfs(root.right, currentSum);
    }
}
// @lc code=end

