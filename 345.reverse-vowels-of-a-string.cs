/*
 * @lc app=leetcode id=345 lang=csharp
 *
 * [345] Reverse Vowels of a String
 */

// @lc code=start
public class Solution
{
    public string ReverseVowels(string s)
    {
        var ss = s.ToCharArray();
        var (l, r) = (0, s.Length - 1);
        var vowels = "aeiouAEIOU";
        while (l < r)
        {
            while (l < r && !vowels.Contains(ss[l])) l++;
            while (l < r && !vowels.Contains(ss[r])) r--;
            if (l < r)
            {
                (ss[l], ss[r]) = (ss[r], ss[l]);
                r--;
                l++;
            }
        }
        return new string(ss);
    }
}
// @lc code=end

