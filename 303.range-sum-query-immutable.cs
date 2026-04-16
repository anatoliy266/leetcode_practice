/*
 * @lc app=leetcode id=303 lang=csharp
 *
 * [303] Range Sum Query - Immutable
 */

// @lc code=start
public class NumArray {

    private int[] _sums;
    // private int[,] dp;
    public NumArray(int[] nums) {
        // _nums = nums;
        // dp = new int[nums.Length, nums.Length];
        // for (var i = 0; i < dp.GetLength(0); i++)
        // {
        //     for (var j = i; j < dp.GetLength(1); j++)
        //     {
        //         dp[i,j] = j > 0 ? dp[i, j-1] + nums[j] : nums[j];
        //     }
        // }
        _sums = new int[nums.Length+1];
        for (var i = 0; i < nums.Length; i++)
        {
            
            _sums[i+1] = _sums[i] + nums[i];
        }
    }
    
    public int SumRange(int left, int right) {
        // var s = 0;
        // while (left < right)
        // {
        //     s += _nums[left++] + _nums[right--];
        // }
        // if (left == right) s += _nums[left];
        // return s;
        // return dp[left, right];
        return _sums[right+1] - _sums[left];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
// @lc code=end

