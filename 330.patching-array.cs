/*
 * @lc app=leetcode id=330 lang=csharp
 *
 * [330] Patching Array
 */

// @lc code=start
public class Solution {
    public int MinPatches(int[] nums, int n) {
        long miss = 1;
        long reach = 0;
        var cnt = 0;
        var i = 0;
        while (reach < n)
        {
            if (i < nums.Length && nums[i] <= miss) {
                reach += nums[i++];
                miss = reach +1;
            } else
            {
                cnt++;
                reach += miss;
                miss = reach +1;
            }
        }
        return cnt;
    }
}
// @lc code=end

