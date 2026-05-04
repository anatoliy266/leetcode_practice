/*
 * @lc app=leetcode id=371 lang=csharp
 *
 * [371] Sum of Two Integers
 */

// @lc code=start
public class Solution {
    public int GetSum(int a, int b) {
        // 1 1
        // 2 10
        // 3 11 
        // 4 100
        // 5 101
        // 6 110
        // 7 111
        // 8 1000

        // 2 010
        // 3 011 
        // 5 101


        // 1 01
        // 2 10
        // 3 11 

        while (b != 0)
        {
            var mask = a & b;
            a = a ^ b;
            b = mask << 1;
        }
        return a;
    }
}
// @lc code=end

