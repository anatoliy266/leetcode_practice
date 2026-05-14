/*
 * @lc app=leetcode id=395 lang=csharp
 *
 * [395] Longest Substring with At Least K Repeating Characters
 */

// @lc code=start
public class Solution
{
    public int LongestSubstring(string s, int k)
    {
        return Dfs(s, 0, s.Length, k);
    }

    public int Dfs(string s, int start, int end, int k)
    {
        if (end - start < k) return 0;
        var freq = new int[26];
        for (var i = start; i < end; i++) freq[s[i] - 'a']++;

        for (var i = start; i < end; i++)
        {
            if (freq[s[i] - 'a'] < k)
            {
                var mid = i + 1;
                while (mid < end && freq[s[mid] - 'a'] < k) mid++;
                if (freq[s[i] - 'a'] < k)
                {
                    var left = Dfs(s, start, i, k);
                    var right = Dfs(s, mid, end, k);
                    return Math.Max(left, right);
                }
            }
        }
        return end - start;
    }
}
// @lc code=end

