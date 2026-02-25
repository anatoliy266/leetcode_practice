/*
 * @lc app=leetcode id=105 lang=csharp
 *
 * [105] Construct Binary Tree from Preorder and Inorder Traversal
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
    public Dictionary<int, int> memo = new Dictionary<int, int>();
    public int mid = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        for (var i = 0; i < inorder.Length; i++)
        {
            memo[inorder[i]] = i;
        }
        return Dfs(preorder, inorder, 0, inorder.Length - 1);
    }

    public TreeNode Dfs(int[] preorder, int[] inorder, int left, int right)
    {
        if (left > right) return null;

        var val = preorder[mid++];
        var node = new TreeNode(val);
        var valIdx = memo[val];
        node.left = Dfs(preorder, inorder, left, valIdx - 1);
        node.right = Dfs(preorder, inorder, valIdx + 1, right);
        return node;
    }
}
// @lc code=end

