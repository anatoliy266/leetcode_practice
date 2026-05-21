/*
 * @lc app=leetcode id=396 lang=csharp
 *
 * [396] Rotate Function
 */

// @lc code=start
public class Solution {
    public int MaxRotateFunction(int[] nums) {
        // var maxSum = int.MinValue;
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     var sum = 0;
        //     for (var j = 0; j < nums.Length; j++)
        //     {
        //         var curr = j+i;
        //         if (curr >= nums.Length) curr = curr % nums.Length;
        //         sum += nums[curr]*j;
        //     }
        //     if (maxSum < sum) maxSum = sum;
        // }
        // return maxSum;
        
        var sum = 0;
        var dp = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            sum+= nums[i];    
            dp[0] += i * nums[i];
        }
        var maxSum = dp[0];
        for (var i = 1; i < nums.Length; i++)
        {
            dp[i] = dp[i-1] + sum - nums.Length * nums[nums.Length-i];
            if (maxSum < dp[i]) maxSum = dp[i];
        }

        return maxSum;
    }
}
// @lc code=end

// 0*A + 1*B + 2*C + 3*D
// 0*D + 1*A + 2*B + 3*C
// F1 - F0 = A + B + C + D - 4*D
// F1 = F0 + A + B + C + D - 4*D

// 0*D + 1*A + 2*B + 3*C
// 0*C + 1*D + 2*A + 3*B
// F2 - F1 = 1*D + 2*A + 3*B - 1*A - 2*B - 3*C
// F2 - F1 = 1*D + 1*A + 1*B - 3*C
// F2 - F1 = 1*D + 1*A + 1*B + 1*C - 4*C
// F2 = F1 + 1*D + 1*A + 1*B + 1*C - 4*C