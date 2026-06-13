/*
 * @lc app=leetcode id=436 lang=csharp
 *
 * [436] Find Right Interval
 */

// @lc code=start
using Microsoft.VisualBasic;

public class Solution
{
    public int[] FindRightInterval(int[][] intervals)
    {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < intervals.Length; i++)
        {
            dict[intervals[i][0]] = i;
        }

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var res = new int[intervals.Length];

        for (var i = 0; i < intervals.Length; i++)
        {
            var end = intervals[i][1];

            var (l, r) = (0, intervals.Length);
            while (l < r)
            {
                var mid = l + (r - l) / 2;
                if (intervals[mid][0] == end)
                {
                    l = mid;
                    break;
                }
                else if (intervals[mid][0] > end) r = mid;
                else l = mid + 1;
            }
            if (l == intervals.Length)
            {
                res[dict[intervals[i][0]]] = -1;
            }
            else
            {
                res[dict[intervals[i][0]]] = dict[intervals[l][0]];
            }


            // var distance = int.MaxValue;
            // var idx = -1;

            // for (var j = 0; j < intervals.Length; j++)
            // {
            //     var start = intervals[j][0];

            //     if (start >= end)
            //     {
            //         if (distance > start - end)
            //         {
            //             distance = start - end;
            //             idx = j;
            //         }
            //     }
            // }
            // res[i] = idx;
        }
        return res;
    }
}
// @lc code=end

