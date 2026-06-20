/*
 * @lc app=leetcode id=446 lang=csharp
 *
 * [446] Arithmetic Slices II - Subsequence
 */

// @lc code=start
public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        Dictionary<long, int>[] dp = new Dictionary<long, int>[nums.Length];

        var res = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            dp[i] = new Dictionary<long, int>();
            for (var j = 0; j < i; j++)
            {
                var diff = (long)nums[i] - nums[j];
                // var curr = dp[i].ContainsKey(diff) ? dp[i][diff] : 0;
                // int val = dp[j].ContainsKey(diff) ? dp[j][diff] : 0;
                dp[i].TryGetValue(diff, out var curr);
                dp[j].TryGetValue(diff, out var val);

                res += val;
                dp[i][diff] = curr + val + 1;
            }
        }
        return res;
    }
}
// @lc code=end

