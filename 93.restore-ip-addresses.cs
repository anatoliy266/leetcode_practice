/*
 * @lc app=leetcode id=93 lang=csharp
 *
 * [93] Restore IP Addresses
 */

// @lc code=start
using System.IO.Pipelines;
using System.Text;

public class Solution {
    private List<string> result =new List<string>();
    public IList<string> RestoreIpAddresses(string s) {
        if (s.Length < 4 || s.Length > 12) return result;
        Backtrack(s,0, new List<string>());
        return result;
    }
    
    public void Backtrack(string s, int idx, List<string> leaf){
        if (idx == s.Length && leaf.Count == 4)
        {
            result.Add(string.Join(".", leaf));
        }
        if (leaf.Count >= 4) return;
        for (var i = 1; i <= 3; i++)
        {
            if (idx + i > s.Length) break;
            var str = s.Substring(idx, i);
            if (str.Length > 1 && str[0] == '0') break;
            var intRepr = int.Parse(str);
            if (intRepr > 255 || intRepr < 0) return;
            leaf.Add(str);
            Backtrack(s, idx+i, leaf);
            leaf.RemoveAt(leaf.Count-1);
        }
    }
}
// @lc code=end

