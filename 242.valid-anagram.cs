/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        // var sArr = s.ToArray();
        // var tArr = t.ToArray();
        // Array.Sort(sArr);
        // Array.Sort(tArr);
        // for (var i = 0; i < sArr.Length; i++)
        // {
        //     if (sArr[i] != tArr[i]) return false;
        // }
        // return true;

        // for (var i = 'a'; i < 'z'; i++)
        // {
        //     var (lFreqA, lFreqB) = (0,0);
        //     for (var j = 0; j < s.Length; j++)
        //     {
        //         if (s[j] == i) lFreqA++;
        //         if (t[j] == i) lFreqB++;
        //     }
        //     if (lFreqA != lFreqB) return false;
        // }
        // return true;

        var freqM = new int[26];
        for (var i = 0; i < s.Length; i++)
        {
            freqM[s[i]-'a']++;
            freqM[t[i]-'a']--;
        }
        foreach (var freq in freqM)
        {
            if (freq != 0) return false;
        }
        return true;
    }
}
// @lc code=end

