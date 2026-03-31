/*
 * @lc app=leetcode id=228 lang=csharp
 *
 * [228] Summary Ranges
 */

// @lc code=start
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        
        var result = new List<string>();
        if (nums.Length == 0) return result;
        var start = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i-1] + 1 != nums[i]) 
            {
                if (start == nums[i-1]) result.Add(start.ToString());
                else result.Add(start + "->" + nums[i-1]);
                start = nums[i];
            }
        }
        result.Add(start == nums[nums.Length-1] ? start.ToString() : start + "->" + nums[nums.Length-1]);
        return result;
    }
}
// @lc code=end

