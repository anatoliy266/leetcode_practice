/*
 * @lc app=leetcode id=215 lang=csharp
 *
 * [215] Kth Largest Element in an Array
 */

// @lc code=start
using System.Runtime.InteropServices.Marshalling;

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // var freq = new int[20001];
        // var offset = 10000;
        // for (var i =0; i < nums.Length; i++)
        // {
        //     freq[nums[i] + offset]++;
        // }
        
        // for (var i = freq.Length-1; i >=0; i--)
        // {
        //     k -= freq[i];
        //     if (k <= 0)
        //     {
        //         return i-offset;
        //     }
        // }
        // return -1;

        var queue = new PriorityQueue<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            queue.Enqueue(nums[i], nums[i]);
            if (queue.Count > k) queue.Dequeue();
        }
        return queue.Peek();
    }
}
// @lc code=end

