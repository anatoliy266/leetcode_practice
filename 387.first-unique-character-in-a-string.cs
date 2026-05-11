/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 */

// @lc code=start
public class Solution
{
    public int FirstUniqChar(string s)
    {
        var freq = new int[26];
        // var dict = new Dictionary<int, int>();
        for (var i = 0; i < s.Length; i++)
        {
            freq[s[i] - 'a']++;
            // dict[s[i] - 'a'] = i;
        }
        // var minIdx = int.MaxValue;
        // for (var i = 0; i < freq.Length; i++)
        // {
        //     if (freq[i] == 1 && dict.TryGetValue(i, out var val))
        //     {
        //         if (minIdx > val) minIdx = val;
        //     }
        // }
        // return minIdx == int.MaxValue ? -1 : minIdx;
        for (var i = 0; i < s.Length; i++)
        {
            if (freq[s[i]-'a'] == 1) return i;
        }
        return -1;
    }
}
// @lc code=end

