/*
 * @lc app=leetcode id=454 lang=csharp
 *
 * [454] 4Sum II
 */

// @lc code=start
using System.Xml;

public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
        var cnt = 0;
        // for (var i = 0; i < nums1.Length; i++)
        // {
        //     for (var j = 0; j < nums2.Length; j++)
        //     {
        //         for (var k = 0; k < nums3.Length; k++)
        //         {
        //             for (var c = 0; c < nums4.Length; c++)
        //             {
        //                 if (nums1[i] + nums2[j] + nums3[k] + nums4[c] == 0) cnt++;
        //             }
        //         }
        //     }
        // }

        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums1.Length; i++)
        {
            for (var j = 0; j < nums2.Length; j++)
            {
                var sum = nums1[i] + nums2[j];
                if (dict.ContainsKey(sum)) dict[sum]++;
                else dict[sum] = 1;
            }
        }

        for (var i = 0; i < nums3.Length; i++)
        {
            for (var j = 0; j < nums4.Length; j++)
            {
                var sum = nums3[i] + nums4[j];
                if (dict.ContainsKey(-sum))
                {
                    cnt+= dict[-sum];
                }
            }
        }


        return cnt;
    }
}
// @lc code=end

