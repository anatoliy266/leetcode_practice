/*
 * @lc app=leetcode id=97 lang=csharp
 *
 * [97] Interleaving String
 */

// @lc code=start
using System.Runtime.Intrinsics.X86;

public class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        var (m, n) = (s1.Length, s2.Length);
        if (m + n != s3.Length) return false;

        var dp = new bool[m + 1, n + 1];
        dp[0, 0] = true;
        for (var i = 0; i <= m; i++)
        {
            for (var j = 0; j <= n; j++)
            {
                if (i > 0 && s3[i + j - 1] == s1[i - 1])
                    dp[i, j] |= dp[i - 1, j];
                if (j > 0 && s3[i + j - 1] == s2[j - 1])
                    dp[i, j] |= dp[i, j - 1];
            }
        }
        return dp[m,n];
    }
}
// @lc code=end

