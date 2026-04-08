/*
 * @lc app=leetcode id=268 lang=csharp
 *
 * [268] Missing Number
 */

// @lc code=start
using System.Collections.Specialized;

public class Solution {
    public int MissingNumber(int[] nums) {
        var d = 0;
        for (var i = 0; i <= nums.Length; i++)
        {
            d ^= i;
        }
        for (var i = 0; i < nums.Length; i++)
        {
            d ^= nums[i];
        }

        return d;

    }
}
// @lc code=end

