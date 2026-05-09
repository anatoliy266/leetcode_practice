/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 */

// @lc code=start
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        // var freq = new Dictionary<char, int>();
        var freq = new int[32];
        for (var i = 0; i < magazine.Length; i++)
        {
            // if (freq.ContainsKey(magazine[i])) freq[magazine[i]]++;
            // else freq[magazine[i]] = 1;

            freq[magazine[i] - 'a']++;
        }

        for (var i = 0; i < ransomNote.Length; i++)
        {
            // if (freq.ContainsKey(ransomNote[i]))
            // {
            //     freq[ransomNote[i]]--;
            //     if (freq[ransomNote[i]] == 0) freq.Remove(ransomNote[i]);
            // } else
            // {
            //     return false;
            // }

            if (freq[ransomNote[i] - 'a']-- <=0) return false;

        }
        return true;
    }
}
// @lc code=end

