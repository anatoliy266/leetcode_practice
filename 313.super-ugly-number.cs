/*
 * @lc app=leetcode id=313 lang=csharp
 *
 * [313] Super Ugly Number
 */

// @lc code=start
using System.Security.Cryptography;

public class Solution
{
    public int NthSuperUglyNumber(int n, int[] primes)
    {
        // var queue = new PriorityQueue<int, int>();
        // var set = new HashSet<int>();
        // queue.Enqueue(1, 1);
        // var cnt = 1;
        // var el = 0;
        // while (queue.Count > 0 && cnt <= n)
        // {
        //     cnt++;
        //     el = queue.Dequeue();
        //     foreach (var p in primes)
        //     {
        //         if (el <= int.MaxValue / p)
        //         {
        //             var pel = p*el;
        //             if (pel >= 0 && set.Add(pel))
        //                 queue.Enqueue(pel ,pel);
        //         }

        //     }
        // }
        // return (int)el;

        var dp = new int[n];
        dp[0] = 1;
        //var (i2, i3, i5) = (0, 0, 0);
        var idxs = new int[primes.Length];
        var nexts = new int[primes.Length];
        // var (next2, next3, next5) = (2, 3, 5);
        Array.Copy(primes, nexts, primes.Length);
        for (var i = 1; i < n; i++)
        {
            dp[i] = nexts.Min();

            for (var j = 0; j < primes.Length; j++)
            {
                if (dp[i] == nexts[j])
                {
                    idxs[j]++;
                    if (dp[idxs[j]] <= int.MaxValue / primes[j])
                    {
                        nexts[j] = dp[idxs[j]] * primes[j];
                    }
                    else
                    {
                        nexts[j] = int.MaxValue;
                    }
                }

            }
        }
        return dp[n - 1];
    }
}
// @lc code=end


