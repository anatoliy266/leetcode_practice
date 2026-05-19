/*
 * @lc app=leetcode id=403 lang=csharp
 *
 * [403] Frog Jump
 */

// @lc code=start
public class Solution {
    public bool CanCross(int[] stones) {
        var dp = new bool[stones.Length+1][];
        for (var i = 0; i < dp.Length; i++)
        {
            dp[i] = new bool[stones.Length+1];
        }
        dp[0][0] = true;
        for (var i = 0; i < stones.Length; i++)
        {
            for (var k = 0; k < stones.Length; k++)
            {
                if (dp[i][k])
                {
                    for (var j = k-1; j <= k+1; j++)
                    {
                        if (j > 0)
                        {
                            for (var c = i+1; c < stones.Length; c++)
                            {
                                if (stones[c] == stones[i] + j) dp[c][j] = true;
                            }
                        }
                    }
                }
            }
        }

        for (var i = 0; i < stones.Length; i++)
        {
            if (dp[stones.Length-1][i]) return true;
        }
        return false;
    }
}
// @lc code=end

