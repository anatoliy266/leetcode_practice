/*
 * @lc app=leetcode id=341 lang=csharp
 *
 * [341] Flatten Nested List Iterator
 */

// @lc code=start
/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {
    private Queue<int> queue = new Queue<int>();
    public NestedIterator(IList<NestedInteger> nestedList) {
        Flatten(nestedList);
    }

    private void Flatten(IList<NestedInteger> list)
    {
        if (list.Count == 0) return;
        for (var i = 0; i < list.Count; i++)
        {
            if (list[i].IsInteger()) queue.Enqueue(list[i].GetInteger());
            else Flatten(list[i].GetList());
        }
    }

    public bool HasNext() {
        return queue.Count > 0;
    }

    public int Next() {
        return queue.Dequeue();
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */
// @lc code=end

