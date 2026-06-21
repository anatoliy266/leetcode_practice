/*
 * @lc app=leetcode id=447 lang=csharp
 *
 * [447] Number of Boomerangs
 */

// @lc code=start
public class Solution
{
    public int NumberOfBoomerangs(int[][] points)
    {
        var cnt = 0;
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < points.Length; i++)
        {
            dict.Clear();
            for (var j = 0; j < points.Length; j++)
            {
                if (i == j) continue;
                // var dist = (int)Math.Pow(points[j][0] - points[i][0], 2) + (int)Math.Pow(points[j][1] - points[i][1], 2);
                var dx = points[j][0] - points[i][0];
                var dy = points[j][1] - points[i][1];
                var dist = dx * dx + dy * dy;

                if (dict.ContainsKey(dist)) dict[dist]++;
                else dict[dist] = 1;


            }
            foreach (var kvp in dict)
            {
                if (kvp.Value > 1)
                {
                    cnt += (kvp.Value - 1) * kvp.Value;
                }
            }
        }

        return cnt;
    }
}
// @lc code=end

