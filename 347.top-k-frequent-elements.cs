/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 */

// @lc code=start
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            freq[nums[i]] = freq.GetValueOrDefault(nums[i], 0)+1;
        }

        var queue = new PriorityQueue<int, int>();
        foreach (var item in freq)
        {
            queue.Enqueue(item.Key, item.Value);
            if (queue.Count > k) queue.Dequeue();
        }

        // while (res.Count < k)
        // {
        //     var el = freq.MaxBy(x => x.Value);
        //     freq[el.Key] = 0;
        //     res.Add(el.Key);
        // }


        var res = new int[k];
        for (int i = k - 1; i >= 0; i--) res[i] = queue.Dequeue();
        return res;
    }
}
// @lc code=end

