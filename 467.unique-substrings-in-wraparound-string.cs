/*
 * @lc app=leetcode id=467 lang=csharp
 *
 * [467] Unique Substrings in Wraparound String
 */

// @lc code=start
public class Solution {
    public int FindSubstringInWraproundString(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        var maxLen = new int[26];
        var currentLen = 0;

        for (var i = 0; i < s.Length; i++) {
            if (i > 0 && (s[i] - s[i - 1] == 1 || s[i - 1] - s[i] == 25)) {
                currentLen++;
            } else {
                currentLen = 1;
            }

            var index = s[i] - 'a';

            maxLen[index] = Math.Max(maxLen[index], currentLen);
        }
        return maxLen.Sum();
    }
}
// @lc code=end

