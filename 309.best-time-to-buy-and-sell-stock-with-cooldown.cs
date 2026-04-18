/*
 * @lc app=leetcode id=309 lang=csharp
 *
 * [309] Best Time to Buy and Sell Stock with Cooldown
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        var (sell, buy, freeze) = (0, -prices[0],0);
        var prevBuy = buy;
        var prevFreeze = freeze;
        var prevSell = sell;
        for (var i = 1; i < prices.Length; i++)
        {
            prevBuy = buy;
            prevFreeze = freeze;
            prevSell = sell;

            sell = prevBuy + prices[i];
            buy = Math.Max(prevBuy, prevFreeze - prices[i]);
            freeze = Math.Max(prevSell, prevFreeze);
        }

        return Math.Max(sell, freeze);
    }
}
// @lc code=end

