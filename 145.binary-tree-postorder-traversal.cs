/*
 * @lc app=leetcode id=145 lang=csharp
 *
 * [145] Binary Tree Postorder Traversal
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
    public IList<int> PostorderTraversal(TreeNode root) {
        if (root == null) return new List<int>();
        var list = new List<int>();
        
        if (root.left != null) list.AddRange(PostorderTraversal(root.left));
        if (root.right != null) list.AddRange(PostorderTraversal(root.right));
        list.Add(root.val);
        return list;
    }
}
// @lc code=end

