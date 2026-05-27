/*
 * @lc app=leetcode id=413 lang=csharp
 *
 * [413] Arithmetic Slices
 */

// @lc code=start
public class Solution
{
    public int NumberOfArithmeticSlices(int[] nums)
    {
        if (nums.Length < 3) return 0;
        var dp = new int[nums.Length];
        dp[0] = 0;
        dp[1] = 0;
        var delta = nums[1] - nums[0];
        var cnt = 0;
        for (var i = 2; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == delta)
            {
                if (dp[i-1] == 0) dp[i] = 1;
                else dp[i] = dp[i-1]+1;
                cnt+=dp[i];
            }
            else
            {
                delta = nums[i] - nums[i-1];
            }
        }
        return cnt;
    }
}
// @lc code=end

