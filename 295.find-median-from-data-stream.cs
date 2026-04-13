/*
 * @lc app=leetcode id=295 lang=csharp
 *
 * [295] Find Median from Data Stream
 */

// @lc code=start
using System.Dynamic;

public class MedianFinder
{
    // public List<int> List = new List<int>(); 
    PriorityQueue<int, int> left = new PriorityQueue<int, int>(Comparer<int>.Create((a,b) => b-a));
    PriorityQueue<int, int> right = new PriorityQueue<int, int>();
    public MedianFinder() {

    }

    public void AddNum(int num) {
        // List.Add(num);
        if (left.Count > 0 && num < left.Peek())
        {
            left.Enqueue(num, num);
        } else
        {
            right.Enqueue(num, num);
        }

        
        if (left.Count < right.Count)
        {
            var rel = right.Dequeue();
            left.Enqueue(rel,rel);
        } else if (right.Count < left.Count - 1)
        {
            var rel = left.Dequeue();
            right.Enqueue(rel,rel);
        }
    }

    public double FindMedian() {
        // List.Sort();
        // var cnt = List.Count;
        // if (cnt % 2 == 0)
        // {
        //     return (List[cnt/2-1] + List[cnt/2])/2.0;
        // } else
        // {
        //     return List[cnt/2];
        // }
        if (left.Count > right.Count) return left.Peek();
        return (left.Peek() + right.Peek()) / 2.0;
    }
}


/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */
// @lc code=end

