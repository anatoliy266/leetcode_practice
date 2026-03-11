/*
 * @lc app=leetcode id=164 lang=csharp
 *
 * [164] Maximum Gap
 */

// @lc code=start
public class Solution {
    public int MaximumGap(int[] nums) {
        if (nums.Length < 2) return 0;
        var maxDiff = 0;
        // Array.Sort(nums);
        // for (var i = 1; i < nums.Length; i++)
        // {
        //     var d = nums[i] - nums[i-1];
        //     if (d > maxDiff) maxDiff = d;
        // }
        // return maxDiff;

        var mins = new int[nums.Length];
        var maxs = new int[nums.Length];

        var (max, min) = (int.MinValue, int.MaxValue);

        for (var i = 0; i < nums.Length; i++)
        {
            if (max < nums[i]) max = nums[i];
            if (min > nums[i]) min = nums[i];
            maxs[i] = int.MinValue;
            mins[i] = int.MaxValue;
        }

        if (max == min) return 0;

        var gap = Math.Max(1, (max - min) / (nums.Length - 1));

        for (var i =0; i < nums.Length; i++)
        {
            var gapIdx = (int)((nums[i] - min) / gap);
            if (gapIdx >= nums.Length) gapIdx = nums.Length - 1;
            if (maxs[gapIdx] < nums[i]) maxs[gapIdx] = nums[i];
            if (mins[gapIdx] > nums[i]) mins[gapIdx] = nums[i];
        }

        var lastMax = min;
        for (var i =0; i < nums.Length; i++)
        {
            if (mins[i] == int.MaxValue) continue;
            var diff = mins[i] - lastMax;
            if (diff > maxDiff) maxDiff =diff;

            lastMax = maxs[i];
        }
        return maxDiff;
    }
}
// @lc code=end

