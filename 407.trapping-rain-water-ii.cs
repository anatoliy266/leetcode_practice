/*
 * @lc app=leetcode id=407 lang=csharp
 *
 * [407] Trapping Rain Water II
 */

// @lc code=start
using System.Globalization;

public class Solution {
    public int TrapRainWater(int[][] heightMap) {
        if (heightMap.Length == 0) return 0;
        var queue = new PriorityQueue<(int, int, int), int>();
        var visited = new bool[heightMap.Length][];
        for (var i = 0; i < heightMap.Length; i++)
        {
            visited[i] = new bool[heightMap[0].Length];
        }

        var sum = 0;        

        for (var i = 0; i < heightMap.Length; i++)
        {
            queue.Enqueue((heightMap[i][0], i, 0), heightMap[i][0]);
            queue.Enqueue((heightMap[i][heightMap[0].Length-1], i, heightMap[0].Length-1), heightMap[i][heightMap[0].Length-1]);
            visited[i][0] = true;
            visited[i][heightMap[0].Length-1] = true;
        }

        for (var i = 0; i < heightMap[0].Length; i++)
        {
            queue.Enqueue((heightMap[0][i], 0, i), heightMap[0][i]);
            queue.Enqueue((heightMap[heightMap.Length-1][i], heightMap.Length-1, i), heightMap[heightMap.Length-1][i]);
            visited[0][i] = true;
            visited[heightMap.Length-1][i] = true;
        }

        while (queue.Count > 0)
        {
            var (el, r, c) = queue.Dequeue();

            for (var i = r-1; i <= r+1; i++)
            {
                for (var j = c-1; j <= c+1; j++)
                {
                    if (Math.Abs(i - r) + Math.Abs(j - c) != 1) continue;
                    if (i < 0 || i >= heightMap.Length || j < 0 || j >= heightMap[0].Length) continue;
                    if (visited[i][j]) continue;
                    if (el > heightMap[i][j]) sum += el - heightMap[i][j];

                    int nextHeight = Math.Max(heightMap[i][j], el);
                    queue.Enqueue((nextHeight, i, j), nextHeight);
                    visited[i][j] = true;
                }
            }
        }
        return sum;
    }
}
// @lc code=end

