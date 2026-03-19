/*
 * @lc app=leetcode id=201 lang=csharp
 *
 * [201] Bitwise AND of Numbers Range
 */

// @lc code=start
using System.ComponentModel.DataAnnotations;

public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        // long res = 0;
        // for (var i = 0; i < 32; i++)
        // {
        //     var mask = 1L << i;
        //     var valid = true;
        //     for (long j = left;j <= right; j++)
        //     {
        //         if ((mask & j) == 0) {valid = false;break;}
        //     }
        //     if (valid) res |= mask;
        // }
        // return (int)res;
        var cnt = 0;
        while (left < right)
        {
            left >>= 1;
            right >>= 1;
            cnt++;
        }
        return left << cnt;
    }
}
// @lc code=end

