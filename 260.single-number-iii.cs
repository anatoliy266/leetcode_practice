/*
 * @lc app=leetcode id=260 lang=csharp
 *
 * [260] Single Number III
 */

// @lc code=start
public class Solution {
    public int[] SingleNumber(int[] nums) {
        var diff = 0;
        foreach(var n in nums) diff ^= n;

        var mask = diff & -diff;
        var (a,b) = (0,0);
        foreach (var n in nums)
        {
            if ((n & mask) == 0) a ^= n;
            else b ^= n;
        }
        return [a,b];
    }
}
// @lc code=end

