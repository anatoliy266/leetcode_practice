/*
 * @lc app=leetcode id=459 lang=csharp
 *
 * [459] Repeated Substring Pattern
 */

// @lc code=start
using System.Text;

public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        var memo = new int[s.Length];
        var len = 0;
        var i = 1;
        while (i < s.Length)
        {
            // if (s.Length % i == 0)
            // {
            //     var substr = s.Substring(0, i);
            //     var repstr = s.Replace(substr, "");
            //     if (repstr.Length == 0) return true;
            // }
            if (s[i] == s[len])
            {
                len++;
                memo[i] = len;
                i++;
            }
            else
            {
                if (len > 0)
                {
                    len = memo[len-1];
                } else
                {
                    memo[i] = 0;
                    i++;
                }
            }

        }
        var max = memo[s.Length - 1];
        return max > 0 && s.Length % (s.Length - max) == 0;
    }
}
// @lc code=end

