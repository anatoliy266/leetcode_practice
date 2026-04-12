/*
 * @lc app=leetcode id=292 lang=csharp
 *
 * [292] Nim Game
 */

// @lc code=start
public class Solution {
    public bool CanWinNim(int n) {
        // if (n <= 3) return true;
        // var dp = new int[n+1];
        // dp[1] = 1;
        // dp[2] = 1;
        // dp[3] = 1;
        // for (var i = 4; i <= n; i++)
        // {
        //     if (dp[i-1] % 2 == 0) dp[i] = dp[i-1] + 1;
        //     else if (dp[i-2] % 2 == 0) dp[i] = dp[i-2] + 1;
        //     else if (dp[i-3] % 2 == 0) dp[i] = dp[i-3] + 1;
        //     else {
        //         dp[i] = dp[i-1] + 1;
        //     }
        // }
        
        // return dp[n] % 2 != 0;

        return n % 4 != 0;
    }
}
// @lc code=end

