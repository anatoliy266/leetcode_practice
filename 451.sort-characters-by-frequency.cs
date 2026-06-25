/*
 * @lc app=leetcode id=451 lang=csharp
 *
 * [451] Sort Characters By Frequency
 */

// @lc code=start
public class Solution {
    public string FrequencySort(string s) {
        var sortedChars = s.GroupBy(c => c)
                           .OrderByDescending(g => g.Count())
                           .Select(g => new string(g.Key, g.Count()));

        // Объединяем все фрагменты в одну итоговую строку
        return string.Concat(sortedChars);
    }
}
// @lc code=end

