/*
 * @lc app=leetcode id=205 lang=csharp
 *
 * [205] Isomorphic Strings
 */

// @lc code=start
public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var dict = new Dictionary<char, char>();
        for (var i = 0; i < s.Length; i++)
        {
            for (var j = i; j < t.Length; j++)
            {
                if (dict.ContainsKey(s[i])) {
                    if (dict[s[i]] != t[j]) return false;
                    break;
                }
                else
                {
                    if (dict.ContainsValue(t[j])) return false;
                    dict[s[i]] = t[i];
                    break;
                }
            }
        }
        return true;
    }
}
// @lc code=end

