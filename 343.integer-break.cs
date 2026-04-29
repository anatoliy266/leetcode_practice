/*
 * @lc app=leetcode id=343 lang=csharp
 *
 * [343] Integer Break
 */

// @lc code=start
public class Solution {
    public int IntegerBreak(int n) {
        if (n <= 3) return n - 1;
        var dp = new int[n+1];
        dp[0] = 0;
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 3;

        for (var i = 4; i <= n; i++)
        {
            for (var j = 1; j <= i / 2; j++)
            {
                var l = j;
                var r = i - j;
                dp[i] = Math.Max(dp[i], dp[j] * dp[i-j]);
            }
        }
        return dp[n];
    }
}
// @lc code=end

