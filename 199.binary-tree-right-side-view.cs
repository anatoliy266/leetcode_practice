/*
 * @lc app=leetcode id=199 lang=csharp
 *
 * [199] Binary Tree Right Side View
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
    public IList<int> RightSideView(TreeNode root) {
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var res = new List<int>();
        if (root == null) return res;
        while (queue.Count > 0)
        {
            var qL = queue.Count;
            for (var i = 0; i < qL; i++)
            {
                var el = queue.Dequeue();
                if (el.right != null) queue.Enqueue(el.right);
                if (el.left != null) queue.Enqueue(el.left);

                if (i == 0)
                {
                    res.Add(el.val);
                }
            }
        }
        return res;
    }
}
// @lc code=end

