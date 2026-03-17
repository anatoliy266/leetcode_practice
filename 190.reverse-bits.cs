/*
 * @lc app=leetcode id=190 lang=csharp
 *
 * [190] Reverse Bits
 */

// @lc code=start
using Microsoft.VisualBasic;

public class Solution {
    
    public int ReverseBits(int n) {
        var res = 0;
        for (var i = 32; i >=1; i--)
        {
            res = res << 1;
            res |= n&1;
            n = n >> 1;
        }
        return res;
    }
}
// @lc code=end

