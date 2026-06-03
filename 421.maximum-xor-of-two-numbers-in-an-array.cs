/*
 * @lc app=leetcode id=421 lang=csharp
 *
 * [421] Maximum XOR of Two Numbers in an Array
 */

// @lc code=start
using System.Net.NetworkInformation;

public class Solution
{
    public int FindMaximumXOR(int[] nums)
    {
        // var maxXor = 0;
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     for (var j = i+1; j < nums.Length; j++)
        //     {
        //         if ((nums[i] ^ nums[j]) > maxXor) maxXor = nums[i] ^ nums[j];
        //     }
        // }
        // return maxXor;

        
        var max = 0;
        var mask = 0;
        for (var i = 31; i >= 0; i--)
        {
            var filtered = new HashSet<int>();
            mask |= (1 << i);
            for (var j = 0; j < nums.Length; j++)
            {
                filtered.Add(mask & nums[j]);
            }


            var cand = max | (1 << i);
            foreach (var pref in filtered)
            {
                if (filtered.Contains(pref ^ cand))
                {
                    max = cand;
                    break;
                }
            }

        }
        return max;
    }
}
// @lc code=end

