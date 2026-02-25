/*
 * @lc app=leetcode id=106 lang=csharp
 *
 * [106] Construct Binary Tree from Inorder and Postorder Traversal
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
    public Dictionary<int, int> memo = new Dictionary<int, int>();
    public int mid = 0;
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        for (var i = 0; i < inorder.Length; i++)
        {
            memo[inorder[i]] = i;
        }
        mid = postorder.Length -1;
        return Dfs(postorder, inorder, 0, inorder.Length - 1);
    }

    public TreeNode Dfs(int[] postorder, int[] inorder, int left, int right)
    {
        if (left > right) return null;
        if (mid < 0) return null;

        var val = postorder[mid--];
        var node = new TreeNode(val);
        var valIdx = memo[val];
        node.right = Dfs(postorder, inorder, valIdx + 1, right);
        node.left = Dfs(postorder, inorder, left, valIdx - 1);
        
        return node;
    }
    
}
// @lc code=end

