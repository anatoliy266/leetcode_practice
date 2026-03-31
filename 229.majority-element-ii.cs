/*
 * @lc app=leetcode id=229 lang=csharp
 *
 * [229] Majority Element II
 */

// @lc code=start
public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        // var dict = new Dictionary<int, int>();
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     if (!dict.TryGetValue(nums[i], out int count)) {
        //         dict[nums[i]] = 1;
        //     } else {
        //         dict[nums[i]] = count + 1;
        //     }
        // }
        // var res = new List<int>();
        // var threshold = nums.Length / 3;
        // // return dict.Where(x => x.Value > nums.Length / 3).Select(x => x.Key).ToList();
        // foreach (var el in dict)
        // {
        //     if (el.Value > threshold) res.Add(el.Key);
        // }
        // return res;
        // var dict = new Dictionary<int, int>();
        // for (var i = 0; i < 3; i++)
        // {
        //     dict[nums[i]] = 1;
        // }

        // for (var i = 3; i < nums.Length; i++)
        // {
        //     if (!dict.TryGetValue(nums[i], out var val))
        //     {
        //         foreach (var key in dict.Keys)
        //         {
        //             dict[key]--;
        //             if (dict[key] == 0)
        //             {
        //                 dict.Remove(key);
        //                 dict[nums[i]] = 1;
        //             }
        //         }
        //     } else
        //     {
        //         dict[nums[i]] = val +1;
        //     }
        // }
        // var res = new List<int>();
        // foreach (var el in dict)
        // {
        //     if (el.Value > 0) res.Add(el.Key);
        // }
        // return res;

        var (k1,k2, c1,c2) = (0,0,0,0);//(nums[0], nums[1], 1,1);
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == k1) c1++;
            else if (nums[i] == k2) c2++;
            else if (c1 == 0 && nums[i] != k2)
            {
                k1 = nums[i];
                c1 = 1;
            }
            else if (c2 == 0 && nums[i] != k1)
            {
                k2 = nums[i];
                c2 = 1;
            }
            else
            {
                c1--;
                c2--;
            }
        }
        c1 = 0; c2 = 0;
        foreach (var n in nums) {
            if (n == k1) c1++;
            else if (n == k2) c2++;
        }

        var result = new List<int>();
        if (c1 > nums.Length / 3) result.Add(k1);
        if (c2 > nums.Length / 3) result.Add(k2);
        
        return result;
    }
}
// @lc code=end

