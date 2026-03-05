/*
 * @lc app=leetcode id=136 lang=csharp
 *
 * [136] Single Number
 */

// @lc code=start
public class Solution {
    public int SingleNumber(int[] nums) {
        // Array.Sort(nums);
        // if (nums.Length ==1) return nums[0]; 
        // if (nums[0] != nums[1]) return nums[0];
        // if (nums[nums.Length-1] != nums[nums.Length-2]) return nums[nums.Length-1];
        // for (var i = 1; i < nums.Length-1; i++)
        // {
        //     if (nums[i] != nums[i-1] && nums[i] != nums[i+1] && nums[i+1] != nums[i-1]) 
        //         return nums[i];            
        // }
        // return nums[0];
        var res = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            res ^= nums[i];
        }
        return res;
    }
}
// @lc code=end

