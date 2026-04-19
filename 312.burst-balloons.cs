/*
 * @lc app=leetcode id=312 lang=csharp
 *
 * [312] Burst Balloons
 */

// @lc code=start
public class Solution {
    public int MaxCoins(int[] nums) {
        int[] temp = new int[nums.Length + 2];
        temp[0] = 1;
        temp[nums.Length + 1] = 1;
        for (int i = 0; i < nums.Length; i++) temp[i + 1] = nums[i];
        var dp = new int[temp.Length][];
        for (var i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[temp.Length];
        }

        for (var h = 2; h < temp.Length; h++)
        {
            for (var l = 0; l < temp.Length - h; l++)
            {
                var r = l + h;
                for (var i = l+1; i < r; i++)
                {
                    var profit = dp[l][i] + dp[i][r] + temp[l] * temp[i] * temp[r];
                    if (profit > dp[l][r]) dp[l][r] = profit;
                }
            }
        }
        return dp[0][nums.Length+1];
    }
}
// @lc code=end

