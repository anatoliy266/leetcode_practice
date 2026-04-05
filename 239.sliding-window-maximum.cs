/*
 * @lc app=leetcode id=239 lang=csharp
 *
 * [239] Sliding Window Maximum
 */

// @lc code=start
public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        // var left = 0;
        // var maxVal = int.MinValue;
        // var maxprevpos = -1;
        // var result = new List<int>();
        // while (left <= nums.Length - k)
        // {
        //     if (left > maxprevpos)
        //     {
        //         maxVal = int.MinValue;
        //         for (int i = left; i < left + k; i++)
        //         {
        //             if (nums[i] >= maxVal)
        //             {
        //                 maxVal = nums[i];
        //                 maxprevpos = i;
        //             }
        //         }
        //     }
        //     else
        //     {
        //         var currentRight = left + k - 1;
        //         if (nums[currentRight] >= maxVal)
        //         {
        //             maxVal = nums[currentRight];
        //             maxprevpos = currentRight;
        //         }
        //     }
        //     result.Add(maxVal);
        //     left++;
        // }
        // return result.ToArray();

        var deque = new LinkedList<int>();
        var res = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (deque.Count > 0 && deque.First.Value <= i-k) deque.RemoveFirst();
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i]) deque.RemoveLast();
            deque.AddLast(i);
            if (i >= k-1) res.Add(nums[deque.First.Value]);
        }
        return res.ToArray();
    }
}
// @lc code=end

