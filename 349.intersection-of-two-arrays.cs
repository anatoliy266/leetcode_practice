/*
 * @lc app=leetcode id=349 lang=csharp
 *
 * [349] Intersection of Two Arrays
 */

// @lc code=start
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        // return nums1.Intersect(nums2).Distinct().ToArray();

        var hash = new HashSet<int>(nums1);
        var res = new HashSet<int>();
        foreach (var num in nums2)
        {
            if (hash.Contains(num)) res.Add(num);
        }
        return res.ToArray();
    }
}
// @lc code=end

