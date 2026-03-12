/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 */

// @lc code=start
using System.Globalization;

public class Solution {
    public int MajorityElement(int[] nums) {
        // var res = 0;
        // for (var i = 0; i < 32; i++)
        // {
        //     var mask = (1 << i);
        //     var cnt = 0;
        //     foreach(var num in nums)
        //     {
        //         if ((num & mask) != 0) cnt++;
                
        //     }
        //     if (cnt > nums.Length / 2) res |= mask;
        // }
        // return res;

        var cnt = 0;
        var candidate  =0;
        for(var i = 0; i < nums.Length; i++)
        {
            if (cnt == 0) candidate = nums[i];
            if (nums[i] == candidate) cnt++;
            else cnt--;
        }
        return candidate;
    }
}
// @lc code=end

