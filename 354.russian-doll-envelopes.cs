/*
 * @lc app=leetcode id=354 lang=csharp
 *
 * [354] Russian Doll Envelopes
 */

// @lc code=start
using System.Security.AccessControl;

public class Solution {
    public int MaxEnvelopes(int[][] envelopes) {
        // var envelopesSort = envelopes.OrderBy(x => x[0]).ThenByDescending(x => x[1]).ToArray();
        Array.Sort(envelopes, (a, b) => {
            if (a[0] == b[0]) return b[1].CompareTo(a[1]); 
            return a[0].CompareTo(b[0]);
        });
        var tails = new List<int>();

        for (var i = 0; i < envelopes.Length; i++)
        {
            var h = envelopes[i][1];

            var (l,r) = (0, tails.Count);
            while (l < r)
            {
                var mid = l + (r-l) /2;
                if (tails[mid] >= h) r = mid;
                else l = mid+1;
            }
            if (l == tails.Count) tails.Add(h);
            else tails[l] = h;
        }
        return tails.Count;
    }
}
// @lc code=end

