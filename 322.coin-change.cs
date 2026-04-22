/*
 * @lc app=leetcode id=322 lang=csharp
 *
 * [322] Coin Change
 */

// @lc code=start
public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var dp = new int[amount+1];
        for (var i = 1; i < dp.Length; i++)
        {
            dp[i] = amount+1;
        }
        
        for (var i = 1; i <= amount; i++)
        {
            for (var j = 0; j < coins.Length; j++)
            {
                if (coins[j] <= i)
                    dp[i] = Math.Min(dp[i], dp[i-coins[j]] +1);
            }
            
        }
        return dp[amount] > amount ? -1 : dp[amount];
    }
}
// @lc code=end

