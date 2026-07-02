/*
 * @lc app=leetcode id=462 lang=csharp
 *
 * [462] Minimum Moves to Equal Array Elements II
 */

// @lc code=start
public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        
        int median = nums[nums.Length / 2];
        
        int moves = 0;

        foreach (int num in nums) {
            moves += Math.Abs(num - median);
        }
        
        return moves;
    }
}
// @lc code=end

