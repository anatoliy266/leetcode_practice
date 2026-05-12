/*
 * @lc app=leetcode id=389 lang=csharp
 *
 * [389] Find the Difference
 */

// @lc code=start
public class Solution {
    public char FindTheDifference(string s, string t) {
        var (s1, s2) = (0,0);
        foreach (var c in s)
        {
            s1 += c-'a';
        }
        foreach (var c in t)
        {
            s2 += c-'a';
        }
        return (char)((s2-s1) + 'a');
        // var res = 0;
        // for (var i = 0; i < s.Length; i++)
        // {
        //     res ^= s[i];
        // }

        // for (var i = 0; i < t.Length; i++)
        // {
        //     res ^= t[i];
        // }

        // return (char)res;
    }
}
// @lc code=end

