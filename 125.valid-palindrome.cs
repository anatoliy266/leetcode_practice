/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
using System.Runtime.Intrinsics.X86;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var (left, right) = (0, s.Length - 1);
        while (left < right)
        {
            if (!Char.IsLetterOrDigit(s[left])) {left++;continue;}
            if (!Char.IsLetterOrDigit(s[right])) {right--;continue;}
            
            if (Char.ToLower(s[left]) != Char.ToLower(s[right])) return false;
            left++;
            right--;

        }
        return true;
    }
}
// @lc code=end

