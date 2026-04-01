/*
 * @lc app=leetcode id=231 lang=csharp
 *
 * [231] Power of Two
 */

// @lc code=start
using System.Runtime.InteropServices;

public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n <= 0) return false;
        return BitOperations.PopCount((uint)n) == 1;
    }
}
// @lc code=end

