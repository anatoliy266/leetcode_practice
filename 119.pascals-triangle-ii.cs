/*
 * @lc app=leetcode id=119 lang=csharp
 *
 * [119] Pascal's Triangle II
 */

// @lc code=start
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        // var res = new List<int>{1};
        // for (var j = 1; j <= rowIndex; j++)
        // {
        //     res.Add((int)((long)res[j-1]*(rowIndex - (j-1))/j));
        // }
        // return res;
        var dp = new int[rowIndex + 1];
        for (var i = 0; i <= rowIndex; i++)
        {
            dp[i] = 1;
            dp[0] = 1;
            for (var j = i-1; j > 0; j--)
            {
                dp[j] = dp[j]+dp[j-1];
            }
        }
        return dp;
    }
}
// @lc code=end

