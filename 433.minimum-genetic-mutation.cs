/*
 * @lc app=leetcode id=433 lang=csharp
 *
 * [433] Minimum Genetic Mutation
 */

// @lc code=start
public class Solution {
    List<char> chars = new List<char>{'A', 'C', 'G', 'T'};
    public int MinMutation(string startGene, string endGene, string[] bank) {
        var memo = new HashSet<string>();
        var bankset = bank.ToHashSet();
        var res = Dfs(startGene, endGene, bankset, memo);
        return res == int.MaxValue ? -1 : res;
    }

    public int Dfs(string start, string end, HashSet<string> bank, HashSet<string> memo)
    {
        if (start == end)
        {
            return 0;
        }
        var min = int.MaxValue;
        for (var i = 0; i < start.Length; i++)
        {
            for (var j = 0; j < chars.Count; j++)
            {
                var nStr = start.ToCharArray();
                nStr[i] = chars[j];
                var newStr = new string(nStr);
                if (bank.Contains(newStr) && !memo.Contains(newStr))
                {
                    memo.Add(newStr);
                    var res = Dfs(newStr, end, bank, memo);
                    if (res != int.MaxValue && res + 1 < min) 
                    {
                        min = res + 1;
                    }

                    memo.Remove(newStr);
                }
            }
        }
        return min;
    } 
}
// @lc code=end

