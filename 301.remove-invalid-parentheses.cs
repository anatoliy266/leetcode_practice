/*
 * @lc app=leetcode id=301 lang=csharp
 *
 * [301] Remove Invalid Parentheses
 */

// @lc code=start
using Microsoft.VisualBasic;

public class Solution
{
    public IList<string> RemoveInvalidParentheses(string s)
    {
        var found = false;
        var memo = new HashSet<string>();
        var res = new List<string>();
        var queue = new Queue<string>();
        queue.Enqueue(s);
        while (queue.Count > 0)
        {
            var qL = queue.Count;
            for (var i = 0; i < qL; i++)
            {
                var el = queue.Dequeue();
                if (IsValid(el))
                {
                    res.Add(el);
                    found = true;
                }

                if (!found)
                {
                    for (var j = 0; j < el.Length; j++)
                    {
                        if (el[j] == '(' || el[j] == ')')
                        {
                            var ns = el.Remove(j, 1);
                            if (memo.Add(ns))
                            {
                                queue.Enqueue(ns);
                            }
                        }
                    }
                }
            }
            if (found) break;
        }
        return res;
    }

    private bool IsValid(string s)
    {
        int balance = 0;
        foreach (char c in s)
        {
            if (c == '(') balance++;
            else if (c == ')')
            {
                balance--;
                if (balance < 0) return false; 
            }
        }
        return balance == 0;
    }
}
// @lc code=end

