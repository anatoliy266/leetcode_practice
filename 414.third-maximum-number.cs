/*
 * @lc app=leetcode id=414 lang=csharp
 *
 * [414] Third Maximum Number
 */

// @lc code=start
using System.ComponentModel.DataAnnotations;

public class Solution {
    public int ThirdMax(int[] nums) {
        Array.Sort(nums, (a,b) => b.CompareTo(a));
        var cnt = 1;
        var max = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i-1] == nums[i]) continue;
            else
            {
                if (max < nums[i]) max = nums[i];
                cnt++;
                if (cnt == 3) return nums[i];

            }
        }
        return max;
    }
}
// @lc code=end

