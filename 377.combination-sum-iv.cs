/*
 * @lc app=leetcode id=377 lang=csharp
 *
 * [377] Combination Sum IV
 */

// @lc code=start
using System.Globalization;

public class Solution
{
    public int CombinationSum4(int[] nums, int target)
    {
        Array.Sort(nums);
        var dp = new int[target+1];
        dp[0] = 1;
        for (var i = 1; i <= target; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if (i - nums[j] >= 0)
                    dp[i] = dp[i - nums[j]] + dp[i];
                else break;
            }
        }
        return dp[target];
    }

}
// @lc code=end

