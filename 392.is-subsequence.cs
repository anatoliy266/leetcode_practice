/*
 * @lc app=leetcode id=392 lang=csharp
 *
 * [392] Is Subsequence
 */

// @lc code=start
public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0) return true;
        if (t.Length == 0) return false;
        var (slow, fast) = (0, 0);
        while (fast < t.Length)
        {
            if (s[slow] == t[fast])
            {
                if (slow == s.Length-1) return true;
                slow++;
            }
            fast++;
        }
        return false;
    }
}
// @lc code=end

