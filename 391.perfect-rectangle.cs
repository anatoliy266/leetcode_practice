/*
 * @lc app=leetcode id=391 lang=csharp
 *
 * [391] Perfect Rectangle
 */

// @lc code=start
using System.ComponentModel.DataAnnotations;

public class Solution {
    public bool IsRectangleCover(int[][] rectangles) {
        var s = 0;
        var set = new HashSet<(int, int)>();
        var (minX, minY, maxX, maxY) = (int.MaxValue,int.MaxValue,int.MinValue,int.MinValue);
        for (var i = 0; i < rectangles.Length; i++)
        {
            if (rectangles[i][0] > maxX) maxX = rectangles[i][0];
            if (rectangles[i][1] > maxY) maxY = rectangles[i][1];
            if (rectangles[i][2] > maxX) maxX = rectangles[i][2];
            if (rectangles[i][3] > maxY) maxY = rectangles[i][3];

            if (rectangles[i][0] < minX) minX = rectangles[i][0];
            if (rectangles[i][1] < minY) minY = rectangles[i][1];
            if (rectangles[i][2] < minX) minX = rectangles[i][2];
            if (rectangles[i][3] < minY) minY = rectangles[i][3];

            s += (rectangles[i][2] - rectangles[i][0]) * (rectangles[i][3] - rectangles[i][1]);

            var lb = (rectangles[i][0], rectangles[i][1]);
            var ru = (rectangles[i][2], rectangles[i][3]);
            var rb = (rectangles[i][2], rectangles[i][1]);
            var lu = (rectangles[i][0], rectangles[i][3]);
            
            if (!set.Add(lb)) set.Remove(lb);
            if (!set.Add(ru)) set.Remove(ru);
            if (!set.Add(lu)) set.Remove(lu);
            if (!set.Add(rb)) set.Remove(rb);
        }
        
        if (set.Count != 4) return false;
        if (!set.Contains((minX, minY)) || !set.Contains((minX, maxY)) || 
            !set.Contains((maxX, minY)) || !set.Contains((maxX, maxY))) return false;
        var bigS = (maxX - minX) * (maxY - minY);
        if (bigS != s) return false;
        return true;
    }
}
// @lc code=end

