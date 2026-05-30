/*
 * @lc app=leetcode id=416 lang=csharp
 *
 * [416] Partition Equal Subset Sum
 */

// @lc code=start
public class Solution {
    public bool CanPartition(int[] nums) {
        var sum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        if (sum % 2 != 0) return false;
        var subsum = sum / 2;

        var dp = new bool[subsum+1];
        dp[0] = true;
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = subsum; j >= nums[i]; j--)
            {
                dp[j] = dp[j] || dp[j - nums[i]];
            }
        }
        
        return dp[subsum];
    }
}
// @lc code=end

