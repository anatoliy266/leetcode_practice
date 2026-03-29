/*
 * @lc app=leetcode id=222 lang=csharp
 *
 * [222] Count Complete Tree Nodes
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
    public int CountNodes(TreeNode root)
    {
        // if (root is null) return 0;
        // var queue = new Queue<TreeNode>();
        // queue.Enqueue(root);
        // var cnt = 0;
        // while (queue.Count > 0)
        // {
        //     var ql = queue.Count;
        //     for (var i = 0; i < ql; i++)
        //     {
        //         var el = queue.Dequeue();
        //         if (el.left is not null) queue.Enqueue(el.left);
        //         if (el.right is not null)queue.Enqueue(el.right);
        //         cnt++;
        //     }
        // }
        // return cnt;
        if (root is null) return 0;
        var lH = 0;
        var curr = root;
        while (curr.left is not null)
        {
            curr = curr.left;
            lH++;
        }
        
        var (l, r) = (0, (int)Math.Pow(2,lH) - 1);

        while (l <= r)
        {
            var mid = l + (r - l) / 2;
            var tMid = mid;
            var lvlMid = (int)Math.Pow(2,lH) / 2;
            curr = root;
            for (var i =0; i < lH; i++)
            {
                if (tMid >= lvlMid)
                {
                    curr = curr.right;
                    tMid -=(int)lvlMid;
                }
                else
                {
                    curr = curr.left;
                }
                lvlMid /= 2;
                
            }
            if (curr is null) r = mid-1;
            else l = mid+1;
        }
        return (int)Math.Pow(2,lH) - 1 + l;
    }
}
// @lc code=end

