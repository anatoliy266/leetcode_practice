/*
 * @lc app=leetcode id=327 lang=csharp
 *
 * [327] Count of Range Sum
 */

// @lc code=start
using System.Net.WebSockets;

public class Solution
{
    public int CountRangeSum(int[] nums, int lower, int upper)
    {
        var sums = new long[nums.Length + 1];
        for (var i = 0; i < nums.Length; i++)
        {
            sums[i+1] = sums[i] + nums[i];
        }
        
        return SortAndCount(sums, 0, sums.Length, upper, lower);

    }

    public int SortAndCount(long[] sums, int left, int right, int upper, int lower)
    {
        if (right - left <= 1) return 0;
        var mid = left + (right - left) / 2;
        var cnt = SortAndCount(sums, left, mid, upper, lower) + SortAndCount(sums, mid, right, upper, lower);

        
        var (low,up) = (mid, mid);
        for (var i = left; i < mid; i++)
        {
            while (low < right && sums[low] - sums[i] < lower) low++;
            while (up < right && sums[up] - sums[i] <= upper) up++;
            cnt += up-low;
        }

        var temp = new long[right - left];
        var (l,r) = (left,mid);
        for (var i = 0; i < temp.Length; i++)
        {
            if (l >= mid) temp[i] = sums[r++];
            else if (r >= right) temp[i] = sums[l++];
            else if (sums[l] < sums[r]) temp[i] = sums[l++];
            else temp[i] = sums[r++];
        }
        for (var i = left; i < right; i++)
        {
            sums[i] = temp[i - left];
        }
        return cnt;
    }
}
// @lc code=end
