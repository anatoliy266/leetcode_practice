/*
 * @lc app=leetcode id=140 lang=csharp
 *
 * [140] Word Break II
 */

// @lc code=start
using System.Text;

public class Solution {
    int minLen = int.MaxValue;
    int maxLen = 0;
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        var wordSet = wordDict.ToHashSet();
        foreach (string word in wordSet)
        {
            minLen = Math.Min(minLen, word.Length);
            maxLen = Math.Max(maxLen, word.Length);
        }
        var result = new List<string>();
        Backtrack(s, new List<string>(), 0, wordSet, result);
        return result;
    }

    public void Backtrack(string s, List<string> list, int idx, HashSet<string> wordSet, List<string> result)
    {
        
        if (idx == s.Length)
        {
            result.Add(string.Join(" ", list));
            return;
        }
        if (s.Length-idx < minLen) return;
        for (var i = idx+minLen; i <= s.Length && i <= idx+maxLen; i++)
        {
            var w = s.Substring(idx, i-idx);
            if (wordSet.Contains(w))
            {
                list.Add(w);
                Backtrack(s, list, i, wordSet, result);
                list.RemoveAt(list.Count-1);
            }
        }
    }
}
// @lc code=end

