/*
 * @lc app=leetcode id=218 lang=csharp
 *
 * [218] The Skyline Problem
 */

// @lc code=start
using System.ComponentModel.DataAnnotations;

public class Solution {
    public IList<IList<int>> GetSkyline(int[][] buildings) {
        var points = new List<(int x, int h)>();
        var res = new List<IList<int>>();
        foreach (var building in buildings)
        {
            var (left, right, height) = (building[0], building[1], building[2]);
            points.Add((left, -height));
            points.Add((right, height));
        }
        points.Sort();

        //var hs = new List<int>() {1};
        var hs = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        var removed = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        hs.Enqueue(0,0);
        var prevMax = 0;
        foreach (var (x,h) in points)
        {
            // var prev = hs[hs.Count-1];
            var prev = hs.Peek();
            if (h < 0)
            {
                int height = -h;
                hs.Enqueue(height, height);
            } else removed.Enqueue(h, h);
            
            while (removed.Count > 0 && hs.Peek() == removed.Peek()) {
                hs.Dequeue();
                removed.Dequeue();
            }
            int currentMax = hs.Peek();
            if (currentMax != prevMax) {
                res.Add(new List<int> { x, currentMax });
                prevMax = currentMax;
            }
        
        }
        return res;
    }
}
// @lc code=end

