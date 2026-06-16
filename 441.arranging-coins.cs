/*
 * @lc app=leetcode id=441 lang=csharp
 *
 * [441] Arranging Coins
 */

// @lc code=start
public class Solution {
    public int ArrangeCoins(int n) {
        return (int)((Math.Sqrt(1 + 8.0 * n) - 1) / 2);
    }
}
// @lc code=end

