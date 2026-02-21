/*
 * @lc app=leetcode id=96 lang=csharp
 *
 * [96] Unique Binary Search Trees
 */

// @lc code=start
using System.Runtime.Intrinsics.Arm;

public class Solution {
    public int NumTrees(int n) {
        var dp = new  int[n+1];
        dp[0] = 1;
        dp[1] = 1;
        for (var i = 2; i <= n; i++)
        {
            for (var k = 1; k <= i; k++)
            {
                dp[i] += dp[k-1] * dp[i-k];
            }
        }
        return dp[n];
    }
}
// @lc code=end


