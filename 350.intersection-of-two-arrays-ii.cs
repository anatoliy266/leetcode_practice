/*
 * @lc app=leetcode id=350 lang=csharp
 *
 * [350] Intersection of Two Arrays II
 */

// @lc code=start
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums1.Length; i++)
        {
            if (dict.ContainsKey(nums1[i])) dict[nums1[i]]++;
            else dict[nums1[i]] = 1;
        }
        var res = new List<int>();
        for (var i = 0; i < nums2.Length; i++)
        {
            if (dict.ContainsKey(nums2[i]) && dict[nums2[i]] > 0) {
                res.Add(nums2[i]);
                dict[nums2[i]]--;
            }
        } 
        return res.ToArray();
    }
}
// @lc code=end

