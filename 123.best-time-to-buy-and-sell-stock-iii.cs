/*
 * @lc app=leetcode id=123 lang=csharp
 *
 * [123] Best Time to Buy and Sell Stock III
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        var (buy1, buy2, sell1, sell2) = (-prices[0],-prices[0],0,0);
        for (var i =1; i<prices.Length; i++)
        {
            if (-prices[i] > buy1) buy1 = -prices[i];
            if (prices[i] + buy1 > sell1) sell1 = prices[i] + buy1;
            if (sell1 - prices[i] > buy2) buy2 = sell1 - prices[i];
            if (prices[i] + buy2 > sell2) sell2 = prices[i] + buy2;
        }
        return sell2;
    }
}
// @lc code=end

