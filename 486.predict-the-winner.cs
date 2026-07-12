/*
 * @lc app=leetcode id=486 lang=csharp
 *
 * [486] Predict the Winner
 */

// @lc code=start
public class Solution {
    public bool PredictTheWinner(int[] nums) {
        int n = nums.Length;
        if (n % 2 == 0) {
            return true;
        }

        int[,] dp = new int[n, n];

        for (int i = 0; i < n; i++) {
            dp[i, i] = nums[i];
        }

        for (int len = 1; len < n; len++) {
            for (int i = 0; i < n - len; i++) {
                int j = i + len;
                dp[i, j] = Math.Max(nums[i] - dp[i + 1, j], nums[j] - dp[i, j - 1]);
            }
        }
        return dp[0, n - 1] >= 0;
    }
}
// @lc code=end

