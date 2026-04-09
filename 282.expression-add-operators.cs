/*
 * @lc app=leetcode id=282 lang=csharp
 *
 * [282] Expression Add Operators
 */

// @lc code=start
using System.Globalization;
using System.Security.Principal;

public class Solution
{
    // private Dictionary<string, List<(long, string)>> memo = new();
    public IList<string> AddOperators(string num, int target)
    {
        var res = new List<string>();
        if (string.IsNullOrEmpty(num)) return res;
        Backtrack(num, "", 0, 0, target, 0, res);
        return res;
        // var res = Dfs(num);
        // return res.Where(x => x.Item1 == target).Select(x => x.Item2).ToHashSet().ToList();
    }


    public void Backtrack(string num, string currS, long currInt, long prevInt, long target, long pos, List<string> res)
    {
        if (pos == num.Length)
        {
            if (currInt == target) res.Add(currS);
            return;
        }

        for (var i = 1; i + pos <= num.Length; i++)
        {
            var sub = num.Substring((int)pos, i);
            if (sub.Length > 1 && sub[0] == '0') break;
            if (!long.TryParse(sub, out long subInt)) break;
            if (pos == 0)
            {
                Backtrack(num, sub, subInt, subInt, target, pos + i, res);
            }
            else
            {
                Backtrack(num, currS + "+" + sub, currInt + subInt, subInt, target, pos + i, res);
                Backtrack(num, currS + "-" + sub, currInt - subInt, -subInt, target, pos + i, res);
                // Backtrack(num, currS + "/" + sub, (currInt - prevInt) + (subInt / prevInt), subInt / prevInt, target, pos + i, res);
                Backtrack(num, currS + "*" + sub, (currInt - prevInt) + (subInt * prevInt), subInt * prevInt, target, pos + i, res);
            }
        }

    }

    // public List<(long, string)> Dfs(string s)
    // {
    //     if (memo.ContainsKey(s)) return memo[s];
    //     var res = new List<(long, string)>();
    //     if (long.TryParse(s, out long val)) {
    //         if (!(s.Length > 1 && s[0] == '0')) // Проверка на "05"
    //             res.Add((val, s));
    //     }

    //     for (var i = 1; i < s.Length; i++)
    //     {
    //         var lefts = Dfs(s.Substring(0, i));
    //         var rights = Dfs(s.Substring(i));

    //         foreach (var l in lefts)
    //         {
    //             foreach (var r in rights)
    //             {
    //                 res.Add((l.Item1 + r.Item1, l.Item2 + "+" + r.Item2));
    //                 res.Add((l.Item1 - r.Item1, l.Item2 + "-" + r.Item2));
    //                 if (r.Item1 != 0) res.Add((l.Item1 / r.Item1, l.Item2 + "/" + r.Item2));
    //                 res.Add((l.Item1 * r.Item1, l.Item2 + "*" + r.Item2));
    //             }
    //         }
    //     }
    //     memo[s] = res;
    //     return res;
    // }

    // public void Dfs(string num, string currStr, int currInt, int target, List<string> res)
    // {
    //     if (num.Length == 0 && currInt == target) 
    //     {
    //         res.Add(currStr);
    //         return;
    //     }
    //     if (num is null || num.Length == 0) return;

    //     var c = num[0];
    //     var tail = num.Substring(1);
    //     var cInt = c - '0';


    //     Dfs(tail, currStr + "+" + c, currInt + cInt, target, res);
    //     Dfs(tail, currStr + "-" + c, currInt - cInt, target, res);
    //     Dfs(tail, currStr + "*" + c, currInt * cInt, target, res);
    //     Dfs(tail, currStr + "/" + c, currInt / cInt, target, res);

    // }
}
// @lc code=end

