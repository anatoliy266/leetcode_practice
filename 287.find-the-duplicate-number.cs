/*
 * @lc app=leetcode id=287 lang=csharp
 *
 * [287] Find the Duplicate Number
 */

// @lc code=start
public class Solution {
    public int FindDuplicate(int[] nums) {
        // var bits = 0;
        // for (var i = 0; i < 32; i++)
        // {
        //     var cnt = 0;
        //     var etaCnt = 0;
        //     var mask = (1 << i);
        //     for (var j = 0; j < nums.Length; j++)
        //     {
        //         if ((mask & nums[j]) != 0)
        //         {
        //             cnt++;
        //         }

        //         if (j > 0 && (j & mask) != 0) {
        //             etaCnt++;
        //         }   
        //     }
        //     if (cnt > etaCnt) {
        //         bits |= mask;
        //     }
        // }
        // return bits;

        // int res = 0;
        // for (int i = 0; i < 32; i++) {
        //     int count = 0;
        //     for (int j = 0; j < nums.Length; j++) {
        //         if ((nums[j] & (1 << i)) != 0) count++;
        //         if ((j & (1 << i)) != 0) count--;
        //     }
        //     if (count > 0) res |= (1 << i);
        // }
        // return res;

        // var (slow,fast) = (nums[0],nums[0]);
        // do
        // {
        //     slow = nums[slow]; 
        //     fast = nums[nums[fast]];
        // } while (slow != fast);
        // slow = nums[0];
        // while (slow != fast)
        // {
        //     slow = nums[slow];
        //     fast = nums[fast];
        // }

        // return slow;
    }
}
// @lc code=end

