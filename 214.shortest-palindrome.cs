/*
 * @lc app=leetcode id=214 lang=csharp
 *
 * [214] Shortest Palindrome
 */

// @lc code=start
using System.Data.Common;
using System.Runtime.Intrinsics.X86;

public class Solution {
    public string ShortestPalindrome(string s) {
        // if (string.IsNullOrEmpty(s)) return "";
        // var mid = s.Length /2;
        // var palindromes = new List<string>();
        // while (mid >= 0)
        // {
        //     for (var offset = 0; offset < 2; offset++)
        //     {
        //         var isPalindrome = true;
        //         var isValidPalindrome = false;
        //         var prefix = "";
        //         for (var i = 0; i <= s.Length - mid + offset; i++)
        //         {
        //             if (mid - i <= 0) isValidPalindrome = true;
        //             if (mid - i < 0) 
        //             {
        //                 if (mid + offset + i < s.Length) 
        //                     prefix = s[mid + offset + i] + prefix;
        //                 else break; 
        //             }
        //             else if (mid + offset + i >= s.Length || s[mid + offset + i] != s[mid - i])
        //             {
        //                 isPalindrome = false;
        //                 break;
        //             }
        //         }
        //         if (isPalindrome && isValidPalindrome) palindromes.Add(prefix + s);
        //     }
        //     mid--;
        // }
        // return palindromes.OrderBy(p => p.Length).First();
        var rev = new string(s.Reverse().ToArray());
        var ss = s + "#" + rev;
        var cnt = 0;
        var dp = new int[ss.Length];
        dp[0] = 0;

        for (var i = 1; i < ss.Length; i++)
        {
            var j = dp[i-1];
            while (j > 0 && ss[i] != ss[j]) j = dp[j-1];
            if (ss[i] == ss[j]) j++;
            dp[i] = j;
        }
        return rev.Substring(0, rev.Length - dp[ss.Length-1]) + s;
    }
}
// @lc code=end

