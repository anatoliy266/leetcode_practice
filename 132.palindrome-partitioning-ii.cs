/*
 * @lc app=leetcode id=132 lang=csharp
 *
 * [132] Palindrome Partitioning II
 */

// @lc code=start
public class Solution {
    public int MinCut(string s) {
        // var dp = new bool[s.Length+1, s.Length+1];
        // dp[0,0] = true;
        // for (var j =0; j < s.Length; j++)
        // {
        //     for (var i = 0; i <= j; i++)
        //     {
        //         if (s[i] == s[j] && (j - i <= 2 || dp[i + 1, j - 1])) {
        //             dp[i, j] = true;
        //         }
        //     }
        // }


        // var ddp = new int[s.Length+1];
        // for (var i = 0; i <= s.Length; i++)
        // {
        //     for (var j = i; j >=0; j--)
        //     {
        //         if (dp[j,i])
        //         {
        //             if (j == 0)ddp[i] = 0;
        //             else ddp[i] = Math.Min(ddp[i], ddp[j-1] + 1);
        //         }
        //     }
        // }
        // return ddp[s.Length];
        var dp = new int[s.Length+1];
        for (var i = 0; i <= s.Length; i++)
        {
            dp[i] = i;
        }

        for (var i = 0; i < s.Length; i++)
        {
            for (var add = 0; add <= 1; add++)
            {
                var (left, right) = (i, i+add);
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    dp[right+1] = Math.Min(dp[left]+1, dp[right+1]);
                    left--;
                    right++;
                }
            }
        }
        return dp[s.Length]-1;

    }
}
// @lc code=end

