/*
 * @lc app=leetcode id=191 lang=csharp
 *
 * [191] Number of 1 Bits
 */

// @lc code=start
using System.Runtime.InteropServices.Marshalling;

public class Solution {
    public int HammingWeight(int n) {
        var cnt = 0;
        for (var i = 1; i <= 32; i++)
        {
            if (((1 << i) & n) != 0) cnt++;
        }
        return cnt;
    }
} 
// @lc code=end

