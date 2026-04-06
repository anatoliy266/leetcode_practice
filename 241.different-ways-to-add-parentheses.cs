/*
 * @lc app=leetcode id=241 lang=csharp
 *
 * [241] Different Ways to Add Parentheses
 */

// @lc code=start
using System.Runtime.CompilerServices;

public class Solution {
    Dictionary<string, List<int>> memo = new Dictionary<string, List<int>>();
    public IList<int> DiffWaysToCompute(string expression) {
        if (memo.TryGetValue(expression, out var val)) return val;
        var res = new List<int>();
        for (var i = 0; i < expression.Length; i++)
        {
            
            var c = expression[i];
            if ("+-*".Contains(c))
            {
                var lefts = DiffWaysToCompute(expression.Substring(0, i));
                var rights = DiffWaysToCompute(expression.Substring(i+1));
                

                foreach (var l in lefts)
                {
                    foreach (var r in rights)
                    {
                        if (c == '+') res.Add(l + r);
                        else if (c == '-') res.Add(l - r);
                        else if (c == '*') res.Add(l * r);
                    }
                }
                
            }
        }
        if (res.Count == 0) res.Add(int.Parse(expression));
        memo[expression] = res;
        return res;
    }

    
}
// @lc code=end

