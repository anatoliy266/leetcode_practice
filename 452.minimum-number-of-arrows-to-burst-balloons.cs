/*
 * @lc app=leetcode id=452 lang=csharp
 *
 * [452] Minimum Number of Arrows to Burst Balloons
 */

// @lc code=start
public class Solution {
    public int FindMinArrowShots(int[][] points) {
        Array.Sort(points, (a,b) => a[1].CompareTo(b[1]));

        var end = points[0][1];
        var cnt = 1;
        for (var i = 1; i < points.Length; i++)
        {
            if (points[i][0] > end)
            {
                cnt++;
                end = points[i][1];
            }
        }
        return cnt;
    }
}
// @lc code=end

