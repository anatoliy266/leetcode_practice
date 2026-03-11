/*
 * @lc app=leetcode id=162 lang=csharp
 *
 * [162] Find Peak Element
 */

// @lc code=start
using System.Security.AccessControl;

public class Solution {
    public int FindPeakElement(int[] nums) {
        var (l, r) = (0, nums.Length-1);

        while (l < r)
        {
            var mid = l + (int)((r-l)/2);

            var midR = mid+1 >= nums.Length ? int.MinValue : nums[mid+1];

            if (nums[mid] > midR) r = mid;
            else l = mid+1;
        }

        return l;

    }
}
// @lc code=end

