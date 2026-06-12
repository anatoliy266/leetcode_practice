/*
 * @lc app=leetcode id=435 lang=csharp
 *
 * [435] Non-overlapping Intervals
 */

// @lc code=start
public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        var end = intervals[0][1];
        var cnt = 0;
        for (var i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < end) cnt++;
            else
            {
                end = intervals[i][1];
            }
        }
        return cnt;
    }
}
// @lc code=end

