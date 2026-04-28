/*
 * @lc app=leetcode id=338 lang=csharp
 *
 * [338] Counting Bits
 */

// @lc code=start
public class Solution {
    public int[] CountBits(int n) {
        // var mask = (1 << (n+1)) - 1;
        var res = new int[n+1];
        for (var i = 0; i <= n; i++)
        {
            var count = 0;
            var c= i;
            while (c > 0) {
                c &= (c - 1);
                count++;
            } 
            res[i] = count;
        } 
        return res;
    }
}
// @lc code=end

