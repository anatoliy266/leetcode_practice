/*
 * @lc app=leetcode id=448 lang=csharp
 *
 * [448] Find All Numbers Disappeared in an Array
 */

// @lc code=start
public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        // var hash = nums.ToHashSet();
        // var res = new List<int>();
        
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     if (!hash.Contains(i+1)) res.Add(i+1);
        // }

        // return res;

        var res = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var targetIndex = Math.Abs(nums[i])-1;

            if (nums[targetIndex] > 0) nums[targetIndex] *= -1;

        }
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0) res.Add(i+1);
        }
        return res;
    }
}
// @lc code=end

