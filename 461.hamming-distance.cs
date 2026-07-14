/*
 * @lc app=leetcode id=461 lang=csharp
 *
 * [461] Hamming Distance
 */

// @lc code=start
public class Solution {
    public int HammingDistance(int x, int y) {
        return BitOperations.PopCount((uint)(x ^ y));
    }
}
// @lc code=end

