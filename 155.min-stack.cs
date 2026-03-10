/*
 * @lc app=leetcode id=155 lang=csharp
 *
 * [155] Min Stack
 */

// @lc code=start
public class MinStack {
    private int[] min;
    private int[] arr;
    private int top;
    private int cap = 16;

    public MinStack() {
        arr = new int[cap];
        min = new int[cap];
        top = -1;
    }
    
    public void Push(int val) {
        if (top == cap - 1)
        {
            cap *=2;
            var newArr = new int[cap];
            var newMin = new int[cap];

            Array.Copy(arr, newArr, arr.Length);
            Array.Copy(min, newMin, min.Length);

            min = newMin;
            arr = newArr;
        }
        top++;
        arr[top] = val;
        if (top == 0)
        {
            min[top] = val;
        }
        else
        {
            min[top] = Math.Min(val, min[top-1]);
        }
    }
    
    public void Pop() {
        if (top >= 0) top--;
    }
    
    public int Top() {
        return arr[top];
    }
    
    public int GetMin() {
        return min[top];
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

