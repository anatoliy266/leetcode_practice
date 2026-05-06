/*
 * @lc app=leetcode id=376 lang=csharp
 *
 * [376] Wiggle Subsequence
 */

// @lc code=start
public class Solution
{
    public int WiggleMaxLength(int[] nums)
    {
        if (nums.Length == 1) return 1;
        var prevSign = 0;
        var cnt = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            if (prevSign <= 0 && nums[i] - nums[i - 1] > 0)
            {
                cnt++;
                prevSign = nums[i] - nums[i - 1];
            }
            else if (prevSign >= 0 && nums[i] - nums[i - 1] < 0)
            {
                cnt++;
                prevSign = nums[i] - nums[i - 1];
            }
        }
        return cnt;
    }
}
// @lc code=end

