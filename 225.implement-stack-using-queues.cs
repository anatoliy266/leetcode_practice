/*
 * @lc app=leetcode id=225 lang=csharp
 *
 * [225] Implement Stack using Queues
 */

// @lc code=start
public class MyStack {

    private Queue<int> mainQ;
    public MyStack() {
        mainQ = new Queue<int>();
    }
    
    public void Push(int x) {
        mainQ.Enqueue(x);
    }
    
    public int Pop() {
        int val = 0;
        var mQL = mainQ.Count;
        for (var i = 0; i < mQL-1; i++)
        {
            val = mainQ.Dequeue();
            mainQ.Enqueue(val);
        }
        val = mainQ.Dequeue();
        return val;
    }
    
    public int Top() {
        int val = 0;
        var mQL = mainQ.Count;
        for (var i = 0; i < mQL; i++)
        {
            val = mainQ.Dequeue();
            mainQ.Enqueue(val);
        }
        return val;
    }
    
    public bool Empty() {
        return mainQ.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

