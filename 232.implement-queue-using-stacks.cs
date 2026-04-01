/*
 * @lc app=leetcode id=232 lang=csharp
 *
 * [232] Implement Queue using Stacks
 */

// @lc code=start
using System.Data.Common;

public class MyQueue {

    private Stack<int> pushStack = new Stack<int>();
    private Stack<int> popStack = new Stack<int>();
    public MyQueue() {
        
    }
    
    public void Push(int x) {
        pushStack.Push(x);
    }
    
    public int Pop() {
        if (popStack.Count == 0)
        {
            while (pushStack.Count > 0) popStack.Push(pushStack.Pop());
        }
        return popStack.Pop();
        // var tempStack = new Stack<int>();
        // while (mainStack.Count > 0)
        // {
        //     tempStack.Push(mainStack.Pop());
        // }
        // var last = tempStack.Pop();
        // while (tempStack.Count > 0) {
        //     mainStack.Push(tempStack.Pop());
        // }
        // return last;
    }
    
    public int Peek() {
        if (popStack.Count == 0)
        {
            while (pushStack.Count > 0) popStack.Push(pushStack.Pop());
        }
        return popStack.Peek();
        // var tempStack = new Stack<int>();
        // while (mainStack.Count > 0)
        // {
        //     tempStack.Push(mainStack.Pop());
        // }
        // var last = tempStack.Peek();
        // while (tempStack.Count > 0) {
        //     mainStack.Push(tempStack.Pop());
        // }
        // return last;
    }
    
    public bool Empty() {
        return popStack.Count == 0 && pushStack.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

