/*
 * @lc app=leetcode id=300 lang=csharp
 *
 * [300] Longest Increasing Subsequence
 */

// @lc code=start
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class Solution
{
    public int maxVAl = int.MinValue;
    public int LengthOfLIS(int[] nums)
    {
        // var dp = new int[nums.Length];
        // int maxLen = 0;
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     var currentMax = 1;
        //     for (var j = 0; j < i; j++)
        //     {
        //         if (nums[i] > nums[j])
        //         {
        //             currentMax = Math.Max(currentMax, dp[j] + 1);
        //         }
        //     }
        //     dp[i] = currentMax;
        //     maxLen = Math.Max(maxLen, dp[i]);
        // }
        // return maxLen;

        // for (var i = 0; i < nums.Length; i++)
        // {
        //     Dfs(nums, i, 1);
        // }
        // return maxVAl;

        var list = new List<int>() {nums[0]};
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > list.Last()) list.Add(nums[i]);
            else
            {
                var (l,r) = (0, list.Count);
                while (l <= r)
                {
                    var mid = l + (r-l)/2;
                    if (nums[i] > list[mid]) l = mid+1;
                    else r = mid-1; 
                }
                list[l] = nums[i];
            }
        }
        return list.Count();

    }

    // public void Dfs(int[] nums, int idx, int cnt)
    // {
    //     var isTerminateState = true;
    //     var i = idx;
    //     var n = cnt+1;
    //     var k = int.MaxValue;
    //     while (i < nums.Length)
    //     {
    //         if (nums[i] > nums[idx] && nums[i] < k)
    //         {
    //             Dfs(nums, i, n);
    //             isTerminateState = false;
    //             k = nums[i];
    //         }
    //         i++;
    //     }
    //     if (isTerminateState && maxVAl < cnt) maxVAl = cnt;
    // }
}
// @lc code=end

// 10,9,12,11,3,7,101,18

// 0 1 3 4 2


// [10,9,2,5,3,7,101,18]
// [0, 1,2,3,4,5,6  ,7]
