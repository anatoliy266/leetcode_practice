/*
 * @lc app=leetcode id=188 lang=csharp
 *
 * [188] Best Time to Buy and Sell Stock IV
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int k, int[] prices) {
        if (k ==0 || prices.Length == 0) return 0;
        
        var buys = new int[k];
        var sells = new int[k];

        Array.Fill(buys, int.MinValue);
        for (var i =0; i<prices.Length; i++)
        {
            for (var j = 0; j < k; j++)
            {
                
                if (j == 0)
                {
                    if (-prices[i] > buys[j]) buys[j] = -prices[i];
                    if (prices[i] + buys[j] > sells[j]) sells[j] = prices[i] + buys[j];
                } else
                {
                    if (sells[j-1] - prices[i] > buys[j]) buys[j] = sells[j-1] - prices[i];
                    if (prices[i] + buys[j] > sells[j]) sells[j] = prices[i] + buys[j];
                }
            }
        }
        return sells[k-1];
    }
}
// @lc code=end

