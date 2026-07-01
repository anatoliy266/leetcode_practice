/*
 * @lc app=leetcode id=458 lang=csharp
 *
 * [458] Poor Pigs
 */

// @lc code=start
public class Solution {
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
        var steps = minutesToTest / minutesToDie;
        for (var i = 1; i < buckets; i++)
        {
            if (Math.Pow(steps+1, i) >= buckets) return i;
        }
        return 0;
    }
}
// @lc code=end

