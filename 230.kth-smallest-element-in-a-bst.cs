/*
 * @lc app=leetcode id=230 lang=csharp
 *
 * [230] Kth Smallest Element in a BST
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
    public int KthSmallest(TreeNode root, int k) {
        var stack = new Stack<TreeNode>();
        var curr = root;
        var cnt = 0;
        while (stack.Count > 0 || curr is not null)
        {
            while (curr is not null)
            {
                stack.Push(curr);
                curr = curr.left;
            }
            
            curr = stack.Pop();
            cnt++;
            if (cnt == k) return curr.val;

            curr = curr.right;
        }
        return -1;
    }
}
// @lc code=end

