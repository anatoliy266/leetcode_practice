/*
 * @lc app=leetcode id=442 lang=csharp
 *
 * [442] Find All Duplicates in an Array
 */

// @lc code=start
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        // var dict = new Dictionary<int, int>();
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     if (dict.ContainsKey(nums[i])) dict[nums[i]]++;
        //     else dict[nums[i]] = 1;
        // }


        // foreach (var kvp in dict)
        // {
        //     if (kvp.Value > 1) res.Add(kvp.Key);
        // }
        // return res;

        // Array.Sort(nums);
        // for (var i = 1; i < nums.Length; i++)
        // {
        //     if (nums[i] == nums[i-1]) res.Add(nums[i]);
        // }
        // return res;

        var res = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            // if (nums[i] < 0) res.Add(nums[i]);
            // else nums[Math.Abs(nums[i])] *= -1;
            int targetIndex = Math.Abs(nums[i]) - 1;

            if (nums[targetIndex] < 0)
            {
                res.Add(targetIndex + 1);
            }
            else
            {
                nums[targetIndex] *= -1;
            }
        }
        return res;
    }
}
// @lc code=end

