/*
 * @lc app=leetcode id=209 lang=csharp
 *
 * [209] Minimum Size Subarray Sum
 */

// @lc code=start
using System.Formats.Asn1;

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        var (slow, fast) = (0,0);
        var minEls = int.MaxValue;
        var sum = 0;
        while (fast < nums.Length)
        {
            sum += nums[fast];
            while (sum >= target)
            {
                if (fast-slow+1 < minEls) minEls = fast-slow+1;
                sum -= nums[slow];
                slow++;
            }
            fast++;
        }
        return minEls == int.MaxValue ? 0 : minEls;

    }
}
// @lc code=end

