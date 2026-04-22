/*
 * @lc app=leetcode id=321 lang=csharp
 *
 * [321] Create Maximum Number
 */

// @lc code=start
using System.Runtime.InteropServices.Marshalling;

public class Solution
{
    public int[] MaxNumber(int[] nums1, int[] nums2, int k)
    {
        var max = new List<int>();
        if (nums2.Length < nums1.Length)
            (nums2, nums1) = (nums1, nums2);
        
        int start = Math.Max(0, k - nums2.Length);
        int end = Math.Min(k, nums1.Length);

        for (var i = start; i <= end; i++)
        // for (var i = 0; i <= nums1.Length; i++)
        {


            var maxL = GetMaxNumber(nums1, i);
            var maxR = GetMaxNumber(nums2, k-i);

            var res = new List<int>();
            var n = 0;
            var c = 0;
            while (res.Count < k)
            {
                if (IsGreater(maxL, n, maxR, c)) res.Add(maxL[n++]);
                else res.Add(maxR[c++]);
            }
            if (IsGreater(res, 0, max, 0)) max = res;
        }
        return max.ToArray();
    }

    private List<int> GetMaxNumber(int[] nums, int len)
    {
        var stack = new Stack<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            while (stack.Count > 0 && nums[i] > stack.Peek() && stack.Count + nums.Length - i > len)
            {
                stack.Pop();
            }
            if (stack.Count < len)
                stack.Push(nums[i]);
        }
        var res = stack.ToList();
        res.Reverse();
        return res;
    }

    private bool IsGreater(List<int> l, int lI, List<int> r, int rI)
    {
        while (lI < l.Count && rI < r.Count && l[lI] == r[rI])
        {
            lI++;
            rI++;
        }
        if (rI == r.Count) return true;
        if (lI == l.Count) return false;
        return l[lI] > r[rI];
    }
}
// @lc code=end

