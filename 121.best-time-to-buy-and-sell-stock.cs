/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0) return 0;
        var (buy, sell) = (prices[0],0);
        for (var i = 1; i < prices.Length; i++)
        {
            if (buy > prices[i]) buy = prices[i];
            else
            {
                if (sell < prices[i] - buy) sell = prices[i] - buy;
            }
        }
        return sell;
    }
}
// @lc code=end

