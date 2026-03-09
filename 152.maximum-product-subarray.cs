/*
 * @lc app=leetcode id=152 lang=csharp
 *
 * [152] Maximum Product Subarray
 */

// @lc code=start
public class Solution
{
    public int MaxProduct(int[] nums)
    {
        var n = nums.Length;

        var dp = nums[0];// new int[n];
        //dp[0] = nums[0];

        var dpMax = nums[0];
        var dpMin = nums[0];


        for (var i = 1; i < nums.Length; i++)
        {
            int cur = nums[i];

            int tempMax = dpMax;

            dpMax = Math.Max(cur, Math.Max(tempMax * cur, dpMin * cur));
            dpMin = Math.Min(cur, Math.Min(tempMax * cur, dpMin * cur));

            dp = Math.Max(dp, dpMax);
        }

        return dp;
    }
}
// @lc code=end

