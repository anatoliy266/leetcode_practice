/*
 * @lc app=leetcode id=220 lang=csharp
 *
 * [220] Contains Duplicate III
 */

// @lc code=start
public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff) {
        // var (slow, fast) = (0,1);
        // while (slow < nums.Length)
        // {
        //     while (fast <= Math.Min(slow + indexDiff, nums.Length - 1))
        //     {
        //         if (Math.Abs(nums[slow] - nums[fast]) <= valueDiff) return true;
        //         fast++;
        //     }
        //     slow++;
        //     fast = slow+1;
        // }
        // return false;
        if (valueDiff < 0) return false;
        var list = new SortedList();

        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var bucketId = nums[i] < 0 ? (nums[i] + 1) / (valueDiff+1) - 1 : nums[i] / (valueDiff+1);

            if (dict.ContainsKey(bucketId)) return true;
            if (dict.TryGetValue(bucketId-1, out var left) && Math.Abs(nums[i] - left) <= valueDiff) return true;
            if (dict.TryGetValue(bucketId+1, out var right) && Math.Abs(nums[i] - right) <= valueDiff) return true;
            
            dict[bucketId] = nums[i];
            if (i >= indexDiff)
            {
                var oldBucketId = nums[i-indexDiff] < 0 ? (nums[i-indexDiff] + 1) / (valueDiff+1) - 1 : nums[i-indexDiff] / (valueDiff+1);
                dict.Remove(oldBucketId);
            }
            dict[bucketId] = nums[i];
        }
        return false;
    }
}
// @lc code=end

