/*
 * @lc app=leetcode id=310 lang=csharp
 *
 * [310] Minimum Height Trees
 */

// @lc code=start
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        // var queue = new Queue<int>();
        // var dict = new Dictionary<int, List<int>>();

        // for (var k = 0; k < n; k++)
        // {
        //     queue.Enqueue(k);
        //     var visited = new HashSet<int>{ k };
        //     var cnt = 1;
        //     while (queue.Count > 0)
        //     {
        //         var qL = queue.Count;
        //         for (var i = 0; i < qL; i++)
        //         {
        //             var el = queue.Dequeue();
        //             foreach (var edge in edges)
        //             {
        //                 int neighbor = -1;
        //                 if (edge[0] == el) neighbor = edge[1];
        //                 else if (edge[1] == el) neighbor = edge[0];

        //                 if (neighbor != -1 && visited.Add(neighbor))
        //                 {
        //                     queue.Enqueue(neighbor);
        //                 }
        //             }
        //         }
        //         cnt++;
        //     }
        //     if (dict.TryGetValue(cnt, out var val))
        //     {
        //         dict[cnt].Add(k);
        //     }
        //     else
        //     {
        //         dict[cnt] = new List<int>() { k };
        //     }
        // }
        // return dict[dict.Keys.Min()];
        if (n == 1) return new List<int> { 0 };
        var freq = new int[n];
        var dict = new Dictionary<int, List<int>>();
        var queue = new Queue<int>();

        foreach (var edge in edges)
        {
            freq[edge[0]]++;
            freq[edge[1]]++;
            if (dict.TryGetValue(edge[0], out var val1)) val1.Add(edge[1]);
            else dict[edge[0]] = new List<int> { edge[1] };

            if (dict.TryGetValue(edge[1], out var val2)) val2.Add(edge[0]);
            else dict[edge[1]] = new List<int> { edge[0] };
        }

        for (int i = 0; i < n; i++) if (freq[i] == 1) queue.Enqueue(i);
        int cnt = n;
        while (cnt > 2)
        {
            var qL = queue.Count;
            cnt -= qL;
            for (var i = 0; i < qL; i++)
            {
                var el = queue.Dequeue();
                foreach (var node in dict[el])
                {
                    if (--freq[node] == 1) 
                    {
                        queue.Enqueue(node); 
                    }
                }
            }

        }
        return queue.ToList();
    }
}
// @lc code=end

