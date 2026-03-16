/*
 * @lc app=leetcode id=174 lang=csharp
 *
 * [174] Dungeon Game
 */

// @lc code=start
using System.Net.WebSockets;
using Microsoft.VisualBasic;

public class Solution
{
    public int CalculateMinimumHP(int[][] dungeon)
    {
        var (m, n) = (dungeon.Length, dungeon[0].Length);
        var dp = new int[n];
        dp[n - 1] = 1 - dungeon[m - 1][n - 1];
        if (dp[n - 1] <= 0)
        {
            dp[n - 1] = 1;
        }

        for (var i = n - 2; i >= 0; i--)
        {
            dp[i] = dp[i + 1] - dungeon[m - 1][i];
            if (dp[i] <= 0)
            {
                dp[i] = 1;
            }
        }

        for (var i = m - 2; i >= 0; i--)
        {
            dp[n - 1] = dp[n - 1] - dungeon[i][n - 1];
            if (dp[n - 1] <= 0)
            {
                dp[n - 1] = 1;
            }
            for (var j = n - 2; j >= 0; j--)
            {
                dp[j] = Math.Min(dp[j], dp[j + 1]) - dungeon[i][j];
                if (dp[j] <= 0)
                {
                    dp[j] = 1;
                }
            }
        }
        return dp[0];
    }
}

// @lc code=end

