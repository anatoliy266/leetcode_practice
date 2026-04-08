/*
 * @lc app=leetcode id=274 lang=csharp
 *
 * [274] H-Index
 */

// @lc code=start
public class Solution {
    public int HIndex(int[] citations) {
        // if (citations.Length == 1) return Math.Min(citations[0], 1);
        // var list = new int[citations.Length+1];
        
        // foreach (var c in citations)
        // {
        //     for (var i = 1; i <= citations.Length; i++)
        //     {
        //         if (c >= i) {
        //             list[i]++;
        //         }
        //     }
        // }
        // var maxcit = 0;
        // for (var i = 0; i <= citations.Length; i++)
        // {
        //     if (list[i] >= i)
        //     {
        //         maxcit = Math.Max(maxcit, i);
        //     }
            
        // }
        // return maxcit;

        // Array.Sort(citations);
        // Array.Reverse(citations);
        // int h = 0;
        // for (var i = 0; i < citations.Length; i++)
        // {
        //     if (citations[i] >= i+1) h++;
        // }
        // return h;

        var list = new int[citations.Length+1];
        foreach (var c in citations)
        {
            if (c >= citations.Length) list[citations.Length]++;
            else list[c]++;
        }

        var cnt = 0;
        for (var i = citations.Length; i >=0; i--)
        {
            cnt += list[i];
            if (cnt >= i) return i;
        }
        return 0;
    }
}
// @lc code=end

