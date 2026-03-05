/*
 * @lc app=leetcode id=139 lang=csharp
 *
 * [139] Word Break
 */

// @lc code=start
public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        var wordSet = wordDict.ToHashSet();
        var dp = new bool[s.Length + 1];

        int minLen = int.MaxValue;
        int maxLen = 0;

        foreach (string word in wordDict)
        {
            minLen = Math.Min(minLen, word.Length);
            maxLen = Math.Max(maxLen, word.Length);
        }

        dp[0] = true;
        for (var i = minLen; i <= s.Length; i++)
        {
            for (var j = minLen; j <= maxLen && j <= i; j++)
            {
                if (dp[i - j] && wordSet.Contains(s.Substring(i - j, j))) { 
                    dp[i] = true; 
                    break; 
                }
            }
        }
        return dp[s.Length];
    }
}
// @lc code=end

