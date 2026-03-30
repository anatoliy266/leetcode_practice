/*
 * @lc app=leetcode id=223 lang=csharp
 *
 * [223] Rectangle Area
 */

// @lc code=start
public class Solution {
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        var s1 = (ax2-ax1) * (ay2 - ay1);
        var s2 = (bx2-bx1) * (by2 - by1);
        
        
        var y1 = Math.Max(ay1, by1);
        var y2 = Math.Min(ay2, by2);
        var x1 = Math.Max(ax1, bx1);
        var x2 = Math.Min(ax2, bx2);


        var sD = Math.Max(0, (x2-x1)) * Math.Max(0, (y2-y1));
        return s1 +s2 - sD;
    }
}
// @lc code=end

