/*
 * @lc app=leetcode id=453 lang=csharp
 *
 * [453] Minimum Moves to Equal Array Elements
 */

// @lc code=start
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class Solution {
    public int MinMoves(int[] nums) {
        // if (isEqual(nums)) return 0;
        // var cnt = 0;
        var min = int.MaxValue;
        long sum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (nums[i] < min) min = nums[i];
        }

        return (int)(sum - (min * nums.Length));

        // while (!isEqual(nums))
        // {
        //     var maxIdx = nums.IndexOf(nums.Max());
        //     nums[maxIdx]--;
        //     // for (var i = 0; i < nums.Length; i++)
        //     // {
        //     //     if (i == maxIdx) continue;
        //     //     nums[i]++;
        //     // }
        //     cnt++;
        // }
        // return cnt;
    }

    // private bool isEqual(int[] nums)
    // {
    //     var set = new HashSet<int>();
    //     foreach (var num in nums)
    //     {
    //         set.Add(num);
    //     }
    //     return set.Count == 1;
    // }
}
// @lc code=end

//  1 2 3 4 5 6 7
//  2 3 4 5 6 7 7
//  3 4 5 6 7 8 7
//  4 5 6 7 8 8 8
//  5 6 7 8 9 8 9
//  6 7 8 9  9  9  10
//  7 8 9 10 10 10 10
//  8 9 10 11 11 10 11
//  9 10 11 11 12 11 12
//  10 11 12 12 12 12 13
//  11 12 13 13 13 13 13
//  12 13 14 14 14 13 14
//  13 14 15 15 15 14 14
//  14 15 16 16 15 15 15
//  15 16 16 17 16 16 16
//  16 17 17 17 17 17 17
//  17 18 18 18 18 17 18
//  18 19 19 19 18 18 19
//  19 20 20 20 19 19 19
//  20 20 21 21 20 20 20
//  21 21 21 22 21 21 21
//  22 22 22 22 22 22 22