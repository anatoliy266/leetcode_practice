/*
 * @lc app=leetcode id=455 lang=csharp
 *
 * [455] Assign Cookies
 */

// @lc code=start
public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);

        var cnt = 0;

        var (l1,l2) = (0,0);

        while (l1 < g.Length && l2 < s.Length)
        {
            if (g[l1] <= s[l2])
            {
                cnt++;
                l1++;
                l2++;
            } else 
            {
                l2++;
            }

        }
        return cnt;

        // for (var i = 0; i < g.Length; i++)
        // {
        //     for (var j = 0; j < s.Length; j++)
        //     {
        //         if (s[j] >= g[i])
        //         {
        //             cnt++;
        //             break;
        //         }
        //     }

        // }
        return cnt;
    }
}
// @lc code=end

