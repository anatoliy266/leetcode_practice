/*
 * @lc app=leetcode id=398 lang=csharp
 *
 * [398] Random Pick Index
 */

// @lc code=start
public class Solution {
    // private int[] _nums;
    Dictionary<int, List<int>> idxs = new Dictionary<int, List<int>>();
    public Solution(int[] nums) {
        // _nums = nums;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (idxs.ContainsKey(nums[i])) idxs[nums[i]].Add(i);
            else idxs[nums[i]] = new List<int>{i};
        }
    }
    
    public int Pick(int target) {
        // var idx = 0;
        // var scope = 1;
        // for (var i = 0; i < _nums.Length; i++)
        // {
        //     if (_nums[i] == target)
        //     {
        //         if (Random.Shared.Next(scope) == 0) idx = i;
        //         scope++;
        //     }
        // }
        // return idx;

        var list = idxs[target];
        var i = Random.Shared.Next(list.Count);
        return list[i];

    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */
// @lc code=end

