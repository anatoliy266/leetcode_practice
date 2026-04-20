/*
 * @lc app=leetcode id=315 lang=csharp
 *
 * [315] Count of Smaller Numbers After Self
 */

// @lc code=start
using System.Globalization;

public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        // var res = new List<int>();
        // var ns = new int[nums.Length];
        // Array.Copy(nums, ns, nums.Length);
        // Array.Sort(ns);

        // var ns = new List<int>(nums);
        // ns.Sort();
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     var d = nums[i];
            
        //     var (left,right) = (0, ns.Count);
        //     while (left < right)
        //     {
        //         var mid = left + (right - left)/2;
        //         if (ns[mid] >= d) right = mid;
        //         else left = mid+1;
        //     }
        //     res.Add(left);
        //     ns.RemoveAt(left);
        // }
        // return res;
        var res = new int[nums.Length];
        var freq = new int[20001];
        var blockSize = (int)Math.Sqrt(freq.Length);
        
        var l1 = new int[freq.Length / blockSize +1];
        var extraBlockSize = (int)Math.Sqrt(l1.Length);
        var l2 = new int[l1.Length / extraBlockSize +1];
        
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            var sum = 0;
            var val = nums[i] + 10000;
            
            var superIdx = val / blockSize;
            var extraIdx = superIdx / extraBlockSize;
            
            for (var j = 0; j < extraIdx; j++)
                sum += l2[j];

            
            for (var j = extraIdx*extraBlockSize; j < superIdx; j++)
                sum += l1[j];

            for (var j = superIdx*blockSize; j < val; j++)
                sum += freq[j];
            res[i] = sum;
            
            freq[val]++;
            l1[val / blockSize]++;
            l2[extraIdx]++;
        }
        return res;
    }
}
// @lc code=end

