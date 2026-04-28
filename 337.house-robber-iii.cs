/*
 * @lc app=leetcode id=337 lang=csharp
 *
 * [337] House Robber III
 */

// @lc code=start

using System.Runtime.Intrinsics.Arm;

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
    public int Rob(TreeNode root) {
        // var list = new List<int>();

        // var queue =new Queue<TreeNode>();
        // queue.Enqueue(root);
        // while (queue.Count > 0)
        // {
        //     var qL = queue.Count;
        //     var sum = 0;
        //     for (var j = 0; j < qL; j++)
        //     {
        //         var el = queue.Dequeue();
        //         sum += el.val;
        //         if (el.left is not null) queue.Enqueue(el.left);                
        //         if (el.right is not null) queue.Enqueue(el.right);
        //     }
        //     list.Add(sum);
        // }

        // var dp = new int[list.Count];
        // dp[0] = list[0];
        // dp[1] = Math.Max(list[0], list[1]);

        // for (var i = 2; i < dp.Length; i++)
        // {
        //     dp[i] = Math.Max(dp[i-1], list[i] + dp[i-2]);
        // }
        // return dp[list.Count-1];
        var res = Dfs(root);
        return Math.Max(res.rob, res.notRob);
    }

    private (int rob, int notRob) Dfs(TreeNode node)
    {
        if (node is null) return (0, 0);
        var leftProfit = Dfs(node.left);
        var rightProfit = Dfs(node.right);

        var r = node.val + leftProfit.notRob + rightProfit.notRob;
        var nR = Math.Max(leftProfit.rob, leftProfit.notRob) + Math.Max(rightProfit.rob, rightProfit.notRob);
        
        return (r,nR);
    }
}
// @lc code=end

