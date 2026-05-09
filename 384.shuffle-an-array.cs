/*
 * @lc app=leetcode id=384 lang=csharp
 *
 * [384] Shuffle an Array
 */

// @lc code=start
public class Solution
{
    int[] _nums;
    public Solution(int[] nums)
    {
        _nums = nums;
    }

    public int[] Reset()
    {
        return _nums;
    }

    public int[] Shuffle()
    {
        var curr = new int[_nums.Length];
        Array.Copy(_nums, curr, _nums.Length);
        // var scope = 1;
        for (var i = curr.Length-1; i > 0; i--)
        {
            var j = Random.Shared.Next(i+1);
            (curr[i], curr[j]) = (curr[j], curr[i]);
        }
        // var (l, r) = (0, curr.Length-1);
        // while (l < r)
        // {
        //     if (Random.Shared.Next(scope++) == 0)
        //     {
        //         (curr[l], curr[r]) = (curr[r], curr[l]);
        //         l++;
        //         r--;
        //     }
        // }
        return curr;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
// @lc code=end

