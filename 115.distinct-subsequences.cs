/*
 * @lc app=leetcode id=115 lang=csharp
 *
 * [115] Distinct Subsequences
 */

// @lc code=start
using System.ComponentModel;
using Microsoft.VisualBasic;

public class Solution
{
    public int NumDistinct(string s, string t)
    {
        // var (m,n) = (s.Length, t.Length);
        // var dp = new int[m+1,n+1];
        // for (var i = 0; i <= m; i++)
        // {
        //     dp[i,0] = 1;
        // }

        // for (var i = 1; i <= m; i++)
        // {
        //     for (var j = 1; j <= n; j++)
        //     {
        //         if (s[i-1] == t[j - 1])
        //         {
        //             dp[i,j] = dp[i-1, j-1] + dp[i-1, j];
        //         } else
        //         {
        //             dp[i,j] = dp[i-1,j];
        //         }
        //     }
        // }
        // return dp[m,n];
        var (m, n) = (s.Length, t.Length);
        var dp = new int[n+1];
        dp[0] =1;
        for (var i = 1; i <= m; i++)
        {
            for (var j = n; j > 0; j--)
            {
                if (s[i-1] == t[j - 1])
                {
                    dp[j] += dp[j-1];
                }
            }
        }
        return dp[n];

    }
}
// @lc code=end

