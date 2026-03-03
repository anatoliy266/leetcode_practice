/*
 * @lc app=leetcode id=131 lang=csharp
 *
 * [131] Palindrome Partitioning
 */

// @lc code=start
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        // var memo = new Dictionary<string, int>();
        var dp = new bool[s.Length+1, s.Length+1];
        dp[0,0] = true;
        for (var j =0; j < s.Length; j++)
        {
            for (var i = 0; i <= j; i++)
            {
                if (s[i] == s[j] && (j - i <= 2 || dp[i + 1, j - 1])) {
                    dp[i, j] = true;
                }
            }
        }


        var result = new List<IList<string>>();
        Backtrack(s, 0, dp, new List<string>(), result);
        return result;
    }

    public void Backtrack(string s, int idx, bool[,] dp, List<string> list, List<IList<string>> result)
    {
        if (idx >= s.Length)
        {
            result.Add(new List<string>(list));
            return;
        }
        for (var i = idx; i < s.Length; i++)
        {
            if (dp[idx, i])
            {
                var sub = s.Substring(idx, i-idx+1);
                list.Add(sub);
                Backtrack(s, i + 1, dp, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }

    // public bool isPalindrome(string s)
    // {
    //     var (left, right) = (0, s.Length - 1);
    //     while (left < right)
    //     {
    //         if (!Char.IsLetterOrDigit(s[left])) { left++; continue; }
    //         if (!Char.IsLetterOrDigit(s[right])) { right--; continue; }

    //         if (Char.ToLower(s[left]) != Char.ToLower(s[right])) return false;
    //         left++;
    //         right--;

    //     }
    //     return true;
    // }
}
// @lc code=end

