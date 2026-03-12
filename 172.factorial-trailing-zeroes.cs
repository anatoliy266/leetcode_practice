/*
 * @lc app=leetcode id=172 lang=csharp
 *
 * [172] Factorial Trailing Zeroes
 */

// @lc code=start
public class Solution {
    public int TrailingZeroes(int n) {
        var cnt  =0;
        while (n >= 5)
        {
            n /= 5;
            cnt+=n;

        }
        return cnt;
    }
}
// @lc code=end

