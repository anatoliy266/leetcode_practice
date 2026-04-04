/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
using System.Runtime.Versioning;

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // var left = new int[nums.Length];
        // var right = new int[nums.Length];
        // var res = new int[nums.Length];
        // left[0] = 1;
        // right[nums.Length-1] = 1;
            
        // for (var i =1; i < nums.Length; i++)
        // {
        //     left[i] = left[i-1]*nums[i-1];
        // }

        // for (var i =nums.Length-2; i >= 0; i--)
        // {
        //     right[i] = right[i+1]*nums[i+1];
        // }
        // for (var i =0; i < nums.Length; i++) res[i] = left[i] * right[i];
        // return res;
        var res = new int[nums.Length];
        res[0] = 1;
            
        for (var i =1; i < nums.Length; i++)
        {
            res[i] = res[i-1]*nums[i-1];
        }

        var temp = 1;
        for (var i =nums.Length-1; i >= 0; i--)
        {
            res[i] = res[i]*temp;
            temp *= nums[i];
        }
        
        return res;
    }
}
// @lc code=end

