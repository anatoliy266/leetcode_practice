/*
 * @lc app=leetcode id=101 lang=csharp
 *
 * [101] Symmetric Tree
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
    public bool IsSymmetric(TreeNode root) {
        var stackL = new Stack<TreeNode>();
        var stackR = new Stack<TreeNode>();
        TreeNode prev = null;
        var left = root.left;
        var right = root.right;



        while (left != null || right != null || stackL.Count  > 0 || stackR.Count > 0)
        {
            while (left != null)
            {
                stackL.Push(left);
                left = left.left;
            }
            while (right != null)
            {
                stackR.Push(right);
                right = right.right;
            }
            if (stackL.Count != stackR.Count) return false;
            
            left = stackL.Pop();
            right = stackR.Pop();

            if (left.val != right.val) return false;

            left = left.right;
            right = right.left;
        }

        return true;
    }
}
// @lc code=end

