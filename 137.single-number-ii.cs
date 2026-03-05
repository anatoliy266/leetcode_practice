/*
 * @lc app=leetcode id=137 lang=csharp
 *
 * [137] Single Number II
 */

// @lc code=start
public class Solution {
    public int SingleNumber(int[] nums) {
        // var res = 0;
        // for (var i =0; i < 32; i++)
        // {
        //     var sum = 0;

        //     var mask = (1 << i);

        //     foreach (var n in nums)
        //     {
        //         if ((n & mask)!=0) sum++;
        //     }

        //     if (sum % 3 != 0) res |= mask;
        // }
        // return res;
        
        
        
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



        var (one,two) = (0,0);
        foreach (var n in nums)
        {
            one = (one ^ n) & ~two;
            two = (two ^ n) & ~one;
        }
        return one;
    }
}
// @lc code=end

