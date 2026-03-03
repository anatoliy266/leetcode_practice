/*
 * @lc app=leetcode id=128 lang=csharp
 *
 * [128] Longest Consecutive Sequence
 */

// @lc code=start
public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        // var parent = new Dictionary<int, int>();
        // var size = new Dictionary<int, int>();

        // foreach (var n in nums)
        // {
        //     parent[n] = n;
        //     size[n] = 1;
        // }

        // foreach (var n in nums)
        // {
        //     if (parent.ContainsKey(n + 1))
        //     {
        //         Union(n, n + 1);
        //     }
        // }
        // return size.Values.Count > 0 ? size.Values.Max() : 0;

        // int Find(int i)
        // {
        //     if (parent[i] == i) return i;

        //     return parent[i] = Find(parent[i]);
        // }

        // void Union(int i, int j)
        // {
        //     var rootI = Find(i);
        //     var rootJ = Find(j);

        //     if (rootI != rootJ)
        //     {
        //         if (rootI < rootJ)
        //         {
        //             parent[rootI] = rootJ;
        //             size[rootJ] += size[rootI];
        //         }
        //         else
        //         {
        //             parent[rootJ] = rootI;
        //             size[rootI] += size[rootJ];
        //         }
        //     }
        // }

        var max = 0;
        var numsSet = nums.ToHashSet();

        foreach (var num in numsSet)
        {
            if (numsSet.Contains(num-1)) continue;
            var depth = 1;
            var curr = num;
            while (numsSet.Contains(curr + 1))
            {
                curr++;
                depth++;
            }
            if (depth > max) max = depth;
        }
        return max;
    }

}
// @lc code=end

