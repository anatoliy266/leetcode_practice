/*
 * @lc app=leetcode id=365 lang=csharp
 *
 * [365] Water and Jug Problem
 */

// @lc code=start
using Microsoft.VisualBasic;

public class Solution {
    public bool CanMeasureWater(int x, int y, int target) {
        if (target > x + y) return false;
        if (target == 0) return true;
        var (i,j) = (x,y);
        while (j != 0)
        {
            var t = i % j;
            i = j;
            j = t;
        }
        return target % i == 0;
    }
}
// @lc code=end

