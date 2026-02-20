/*
 * @lc app=leetcode id=91 lang=csharp
 *
 * [91] Decode Ways
 */

// @lc code=start
using System.Net.NetworkInformation;

public class Solution
{
    public int NumDecodings(string s)
    {
        if (string.IsNullOrEmpty(s) || s[0] == '0') return 0;
        var dp = new int[s.Length+1];
        dp[0] = 1;
        dp[1] = 1;
        for (var i = 2; i <= s.Length; i++)
        {
            ///101010101
            if (s[i-1] != '0')
            {
                dp[i] += dp[i-1];
            } 

            var d2 = int.Parse(s.Substring(i-2, 2));
            if (d2 >=10 && d2 <= 26)
            {
                dp[i] += dp[i-2];
            }
        }
        return dp[s.Length];
    }

}
// @lc code=end

