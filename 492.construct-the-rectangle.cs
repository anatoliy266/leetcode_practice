/*
 * @lc app=leetcode id=492 lang=csharp
 *
 * [492] Construct the Rectangle
 */

// @lc code=start
public class Solution {
    public int[] ConstructRectangle(int area) {
        int w = (int)Math.Sqrt(area);
        
        while (area % w != 0) {
            w--;
        }
        int l = area / w;
        
        return new int[] { l, w };
    }
}
// @lc code=end

