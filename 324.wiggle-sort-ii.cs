/*
 * @lc app=leetcode id=324 lang=csharp
 *
 * [324] Wiggle Sort II
 */

// @lc code=start
using System.Runtime.CompilerServices;

public class Solution {
    public void WiggleSort(int[] nums)
    {
        var n = nums.Length;
        // var sort = new int[n];
        // Array.Copy(nums, sort, n);
        // Array.Sort(sort);
        // var (l,r) = ((n + 1) / 2 - 1, n-1);
        // for (var i = 0; i < n; i++)
        // {
        //     if (i % 2 == 0) nums[i] = sort[l--];
        //     if (i % 2 != 0) nums[i] = sort[r--];
        // }

        var buckets = new int[5001];
        for (var i = 0; i < n; i++) buckets[nums[i]]++;

        var val = 5000;

        for (var i = 1; i < n; i+=2)
        {
            while (buckets[val] == 0) val--;
            nums[i] = val;
            buckets[val]--;
        }

        for (var i = 0; i < n; i+=2)
        {
            while (buckets[val] == 0) val--;
            nums[i] = val;
            buckets[val]--;
        }

    }
}
// @lc code=end

