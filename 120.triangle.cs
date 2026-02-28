/*
 * @lc app=leetcode id=120 lang=csharp
 *
 * [120] Triangle
 */

// @lc code=start
using System.Runtime.Serialization.Formatters;
using Microsoft.VisualBasic;

public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        
        var dp = triangle[triangle.Count-1].ToArray();
        for (var i = triangle.Count-2; i >= 0; i--)
        {
            for (var j = 0; j <= i; j++)
            {
                dp[j] = triangle[i][j] + Math.Min(dp[j], dp[j+1]);
            }
        }
        return dp[0];
    }
}
// @lc code=end

