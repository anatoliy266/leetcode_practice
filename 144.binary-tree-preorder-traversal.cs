/*
 * @lc app=leetcode id=144 lang=csharp
 *
 * [144] Binary Tree Preorder Traversal
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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        if (root == null) return new List<int>();
        var list = new List<int>() { root.val };
        if (root.left != null) list.AddRange(PreorderTraversal(root.left));
        if (root.right != null) list.AddRange(PreorderTraversal(root.right));

        return list;
    }
}
// @lc code=end

