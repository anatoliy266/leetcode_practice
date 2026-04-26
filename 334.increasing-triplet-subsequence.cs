/*
 * @lc app=leetcode id=334 lang=csharp
 *
 * [334] Increasing Triplet Subsequence
 */

// @lc code=start
public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        var (small, big) = (int.MaxValue,int.MaxValue);

        foreach (var n in nums)
        {
            if (n <= small) small = n;
            else if (n <= big) big = n;
            else return true;
        }
        return false;
    }
}
// @lc code=end

