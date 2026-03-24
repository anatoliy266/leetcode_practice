/*
 * @lc app=leetcode id=213 lang=csharp
 *
 * [213] House Robber II
 */

// @lc code=start
public class Solution {
    public int Rob(int[] nums) {
        var woFirst = new List<int>();
        var woLast = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (i == 0) woLast.Add(nums[i]);
            else if (i == nums.Length-1) woFirst.Add(nums[i]);
            else
            {
                woLast.Add(nums[i]);
                woFirst.Add(nums[i]);
            }

        }
        return Math.Max(RobFunc(woFirst.ToArray()), RobFunc(woLast.ToArray()));
    }

    public int RobFunc(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        var dp = new int[nums.Length+1];
        dp[0] = nums[0];
        dp[1] = Math.Max(dp[0], nums[1]);
        for (var i = 2; i < nums.Length; i++)
        {
            dp[i] = Math.Max(dp[i-1], nums[i]+dp[i-2]);
        }
        return dp[nums.Length-1];
    }
}
// @lc code=end

