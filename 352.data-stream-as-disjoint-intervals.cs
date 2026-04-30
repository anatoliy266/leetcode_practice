/*
 * @lc app=leetcode id=352 lang=csharp
 *
 * [352] Data Stream as Disjoint Intervals
 */

// @lc code=start
using Microsoft.VisualBasic;

public class SummaryRanges
{
    // PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
    List<int[]> intervals = new List<int[]>();
    public SummaryRanges()
    {

    }

    public void AddNum(int value)
    {
        // queue.Enqueue(value, value);

        int low = 0, high = intervals.Count - 1;
        int idx = intervals.Count;

        while (low <= high) {
            int mid = low + (high - low) / 2;
            if (intervals[mid][0] >= value) {
                idx = mid;
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        var inPrev = idx > 0 && intervals[idx - 1][1] >= value;
        var inCurr = idx < intervals.Count && intervals[idx][0] <= value;
        if (inPrev || inCurr) return;

        var connectLeft = idx > 0 && intervals[idx - 1][1] + 1 == value;
        var connectRight = idx < intervals.Count && intervals[idx][0] - 1 == value;

        if (connectLeft && connectRight) {
            intervals[idx - 1][1] = intervals[idx][1]; 
            intervals.RemoveAt(idx); 
        }
        else if (connectLeft) {
            intervals[idx - 1][1] = value; 
        }
        else if (connectRight) {
            intervals[idx][0] = value;
        }
        else {
            intervals.Insert(idx, new int[] { value, value });
        }
    }

    public int[][] GetIntervals()
    {
        // var res = new Dictionary<int, List<int>>();
        // var res = new List<int[]>();
        // var tempQ = new PriorityQueue<int, int>(queue.UnorderedItems);
        // var i = 0;
        // while (tempQ.Count > 0)
        // {
        //     var el = tempQ.Dequeue();


        //     if (res.ContainsKey(i)) res[i].Add(el);
        //     else res[i] = new List<int> { el };

        //     if (tempQ.Count > 0 && tempQ.Peek() != el && tempQ.Peek() != el + 1) i++;
        // }
        // return res.Values.Select(x => new int[] {x[0], x[x.Count-1]}).ToArray();
        
        
        // if (queue.Count == 0) return Array.Empty<int[]>();
        // var res = new List<int[]>();
        // var tempQ = new PriorityQueue<int, int>(queue.UnorderedItems);
        // var start = tempQ.Dequeue();
        // var end = start;

        // while (tempQ.Count > 0)
        // {
        //     var el = tempQ.Dequeue();
        //     if (el == end) continue;
        //     if (el == end + 1)
        //     {
        //         end = el;
        //     }
        //     else
        //     {
        //         res.Add(new int[] { start, end });
        //         start = end = el;
        //     }
        // }
        // res.Add(new int[] { start, end });
        // return res.ToArray();
        return intervals.ToArray();
    }
}

/**
 * Your SummaryRanges object will be instantiated and called as such:
 * SummaryRanges obj = new SummaryRanges();
 * obj.AddNum(value);
 * int[][] param_2 = obj.GetIntervals();
 */
// @lc code=end

