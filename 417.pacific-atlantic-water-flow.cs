/*
 * @lc app=leetcode id=417 lang=csharp
 *
 * [417] Pacific Atlantic Water Flow
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        var queue1 = new Queue<(int, int)>();
        var queue2 = new Queue<(int, int)>();
        var set1 = new HashSet<(int, int)>();
        var set2 = new HashSet<(int, int)>();
        var res = new List<IList<int>>();
        if (heights.Length == 0) return res;
        var (r,c) = (heights.Length, heights[0].Length);

        for (var i = 0; i < r; i++)
        {
            queue1.Enqueue((i,0));
            set1.Add((i, 0));
            queue2.Enqueue((i, c-1));
            set2.Add((i, c-1));
        }

        for (var i = 0; i < c; i++)
        {
            queue1.Enqueue((0, i));
            set1.Add((0, i));

            queue2.Enqueue((r - 1, i));
            set2.Add((r - 1, i));
        }

        while (queue1.Count > 0)
        {
            var (i,j) = queue1.Dequeue();
            set1.Add((i,j));
            for (var ii = i-1; ii <= i+1; ii++)
            {
                for (var jj = j-1; jj <= j+1; jj++)
                {
                    if (Math.Abs(ii - i) + Math.Abs(jj - j) != 1) continue;
                    if (ii < 0 || jj < 0 || ii >= r || jj >= c) continue;
                    
                    if (!set1.Contains((ii, jj)) && heights[ii][jj] >= heights[i][j]) {
                        set1.Add((ii, jj));
                        queue1.Enqueue((ii, jj));
                    }
                }
            }
        }

        while (queue2.Count > 0)
        {
            var (i,j) = queue2.Dequeue();
            set2.Add((i,j));
            for (var ii = i-1; ii <= i+1; ii++)
            {
                for (var jj = j-1; jj <= j+1; jj++)
                {
                    if (Math.Abs(ii - i) + Math.Abs(jj - j) != 1) continue;
                    if (ii < 0 || jj < 0 || ii >= r || jj >= c) continue;
                    
                    if (!set2.Contains((ii, jj)) && heights[ii][jj] >= heights[i][j]) {
                        set2.Add((ii, jj));
                        queue2.Enqueue((ii, jj));
                    }
                }
            }
        }

        foreach (var (i,j) in set1)
        {
            if (set2.Contains((i,j))) res.Add(new List<int>{i,j});
        }
        return res;

    }
}
// @lc code=end

