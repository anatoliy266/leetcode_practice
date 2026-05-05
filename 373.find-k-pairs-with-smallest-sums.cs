/*
 * @lc app=leetcode id=373 lang=csharp
 *
 * [373] Find K Pairs with Smallest Sums
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var queue = new PriorityQueue<(int u, int v), int>();
        for (var i = 0; i < nums1.Length; i++)
        {
            queue.Enqueue((i,0), nums1[i]+nums2[0]);
        }
        
        var res = new List<IList<int>>();
        while (k > 0)
        {
            var (u,v) = queue.Dequeue();
            if (v + 1 < nums2.Length)
                queue.Enqueue((u, v+1), nums1[u]+nums2[v+1]);
            res.Add(new List<int>{nums1[u],nums2[v]});
            k--;
        }
        return res;
    }
}
// @lc code=end

// [1,2,2]
// [2,4,6]

// 1,2 - 3 1,4 - 5 1,6 - 7
// 7,2 - 9 7,4 - 11 7,6 - 13
// 11,2 - 13 11,4 - 15 11,6 - 17 


// 1,2 1,4 1,6 2,2 2,4 2,6 2,2 2,4 2,6
// 3    5   7   4   6   8   4    6   8