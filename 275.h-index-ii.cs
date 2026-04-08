/*
 * @lc app=leetcode id=275 lang=csharp
 *
 * [275] H-Index II
 */

// @lc code=start
public class Solution {
    public int HIndex(int[] citations) {
        // Array.Reverse(citations);
        // int h = 0;
        // for (var i = 0; i < citations.Length; i++)
        // {
        //     if (citations[i] >= i+1) h++;
        // }
        // return h;
        var cnt = 0;
        for (var i = citations.Length-1; i >=0; i--)
        {
            cnt++;
            if (citations[i] < cnt) return cnt-1;
        }
        return citations.Length;
        
    }
}
// @lc code=end

