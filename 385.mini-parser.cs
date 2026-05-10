/*
 * @lc app=leetcode id=385 lang=csharp
 *
 * [385] Mini Parser
 */

// @lc code=start
/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // Constructor initializes an empty nested list.
 *     public NestedInteger();
 *
 *     // Constructor initializes a single integer.
 *     public NestedInteger(int value);
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // Set this NestedInteger to hold a single integer.
 *     public void SetInteger(int value);
 *
 *     // Set this NestedInteger to hold a nested list and adds a nested integer to it.
 *     public void Add(NestedInteger ni);
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Solution
{
    public NestedInteger Deserialize(string s)
    {
        var stack = new Stack<NestedInteger>();
        int sign = 1;
        int? d = null;
        for (var i = 0; i < s.Length; i++)
        {
            if (!s.StartsWith('[')) return new NestedInteger(int.Parse(s));

            if (s[i] == '[') stack.Push(new NestedInteger());
            else if (s[i] == ',' || s[i] == ']')
            {
                if (d is not null)
                {
                    stack.Peek().Add(new NestedInteger(d.Value * sign));
                    d = null;
                    sign = 1;
                }
                if (s[i] == ']' && stack.Count > 1)
                {
                    var el = stack.Pop();
                    stack.Peek().Add(el);
                }
            }
            else if (s[i] == '-') sign = -sign;
            else
            {
                d = (d ?? 0) * 10 + (s[i] - '0');
            }
        }
        return stack.Pop();
    }
}
// @lc code=end

// "324" 324
// "[324]" [324]
// "[]" []
// "[[1], [1,2,3], [-123, []], 1, 2, -3]" [[1], [1,2,3], [-123], 1, 2, -3]