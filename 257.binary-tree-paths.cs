/*
 * @lc app=leetcode id=257 lang=csharp
 *
 * [257] Binary Tree Paths
 */

// @lc code=start

using System.Text;

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
    public IList<string> BinaryTreePaths(TreeNode root) {
        var res = new List<string>();
        Dfs(root, "", res);
        return res;
    }

    public void Dfs(TreeNode node, string curr, List<string> res)
    {
        if (node is null) return;

        curr+=node.val;
        if (node.left is null && node.right is null)
        {
            res.Add(curr);
            return;
        } else
        {
            curr+="->";
            Dfs(node.left, curr, res);
            Dfs(node.right, curr, res);
        }
    }
}
// @lc code=end

