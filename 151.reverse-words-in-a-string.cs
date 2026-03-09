/*
 * @lc app=leetcode id=151 lang=csharp
 *
 * [151] Reverse Words in a String
 */

// @lc code=start
public class Solution {
    public string ReverseWords(string s) {
        var list = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(list);
        return string.Join(" ", list);
    }
}
// @lc code=end

