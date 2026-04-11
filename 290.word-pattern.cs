/*
 * @lc app=leetcode id=290 lang=csharp
 *
 * [290] Word Pattern
 */

// @lc code=start
public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var dict = new Dictionary<char, string>();
        var sList = s.Split(" ");
        if (sList.Length != pattern.Length) return false;
        for (var i = 0; i < pattern.Length; i++)
        {
            var c = pattern[i];
            if (dict.TryGetValue(c, out var val))
            {
                if (val != sList[i]) return false;
            }
            else
            {
                if (dict.ContainsValue(sList[i])) return false;
                dict[c] = sList[i];
            }
        }
        return true;
    }
}
// @lc code=end

