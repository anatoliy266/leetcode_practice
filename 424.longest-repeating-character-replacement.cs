/*
 * @lc app=leetcode id=424 lang=csharp
 *
 * [424] Longest Repeating Character Replacement
 */

// @lc code=start
public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        // var (l, r) = (0, 0);
        // var c = k;
        // var max = 0;
        

        // while (r < s.Length)
        // {
        //     if (l == r)
        //     {
        //         r++;
        //     }
        //     else
        //     {
        //         if (c > 0)
        //         {
        //             r++;
        //             c--;
        //         }
        //         else
        //         {
        //             if (c == 0)
        //             {
        //                 if (max < (r - l+1)) max = r - l +1;
        //             }
        //             l++;
        //             c++;
        //         }
        //     }
        // }
        // return max;
        var l = 0;
        var max = 0;
        var maxL = 0;
        var counts = new int[26];

        for (var r = 0; r < s.Length; r++)
        {
            counts[s[r] - 'A']++;
            if (max < counts[s[r] - 'A']) max = counts[s[r] - 'A'];

            if ((r - l + 1) - max > k)
            {
                counts[s[l] - 'A'] --;
                l++;

            }
            if (maxL < (r-l+1)) maxL = r - l + 1;
        }
        return maxL;
    }
}
// @lc code=end
