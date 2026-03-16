/*
 * @lc app=leetcode id=187 lang=csharp
 *
 * [187] Repeated DNA Sequences
 */

// @lc code=start
public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var dict = new Dictionary<string, int>();
        var seen =new HashSet<string>();
        var repeated = new HashSet<string>();
        for (var i = 0; i < s.Length-9; i++)
        {
            var sub = s.Substring(i, 10);
            if (!seen.Add(sub))
            {
                repeated.Add(sub);
            }
        }
        return repeated.ToList();;
    }
}
// @lc code=end

