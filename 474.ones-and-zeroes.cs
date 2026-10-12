/*
 * @lc app=leetcode id=474 lang=csharp
 *
 * [474] Ones and Zeroes
 */

// @lc code=start
public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {
        var dp = new int[m+1, n+1];
        // for (var i = 0; i <= m; i++)
        // {
        //     dp[i] = new int[n+1];
        // }
        dp[0,0] = 0;

        // for (var c = 0; c < strs.Length; c++)
        foreach (var str in strs)
        {
            // var zeros = strs[c].Count(a => a == '0');
            // var ones = strs[c].Count(a => a == '1');
            var zeros = 0;
            var ones = 0;

            foreach (var c in str) 
            {
                if (c == '0') zeros++;
                else ones++;
            }

            for (var i = m; i >= zeros; i--)
            {
                for (var j = n; j >=ones; j--)
                {
                    // if (i - zeros >= 0 && j - ones >= 0)
                    var nv = dp[i-zeros,j-ones] + 1;
                    // dp[i,j] = Math.Max(dp[i,j], dp[i-zeros,j-ones] + 1);
                    if (nv > dp[i,j]) dp[i,j] = nv;
                }
            }
        }

        return dp[m,n];
    }
}
// @lc code=end

