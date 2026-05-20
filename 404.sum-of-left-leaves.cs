/*
 * @lc app=leetcode id=404 lang=csharp
 *
 * [404] Sum of Left Leaves
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
    public int SumOfLeftLeaves(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var s = 0;
        while (queue.Count > 0)
        {
            var el = queue.Dequeue();
            if (el.left is not null)
            {
                if (el.left.left is null && el.left.right is null)
                {
                    s += el.left.val;
                }
                else
                {
                    queue.Enqueue(el.left);
                }
            }
            if (el.right is not null)
                queue.Enqueue(el.right);
        }
        return s;
    }
}
// @lc code=end

