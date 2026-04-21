/*
 * @lc app=leetcode id=316 lang=csharp
 *
 * [316] Remove Duplicate Letters
 */

// @lc code=start
using System.Text;
using Microsoft.VisualBasic;

public class Solution {
    public string RemoveDuplicateLetters(string s) {
        // var freq = new int[26];
        // for (var i = 0; i < s.Length; i++) freq[s[i] - 'a']++;
        // var totalUniqueCount = 0;
        // var bestRes = "";
        // for (int i = 0; i < 26; i++) {
        //     if (freq[i] > 0) totalUniqueCount++;
        // }
        // var res = new List<string>();
        // Dfs(s, "", res, 0, totalUniqueCount, freq, new bool[26]);
        // return res.Min();\

        
        var stack = new Stack<char>();
        var visited = new bool[26];  
        var freq = new int[26];
        for (var i = 0; i < s.Length; i++) freq[s[i] - 'a']++;

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            var cI = c - 'a';

            freq[cI]--;
            if (visited[cI]) continue;

            while (stack.Count > 0 && stack.Peek() > c && freq[stack.Peek() - 'a'] > 0)
            {
                var el = stack.Pop();
                visited[el-'a'] = false;
            }
            stack.Push(c);
            visited[cI] = true;
        }

        var res = new StringBuilder();
        while (stack.Count > 0)
        {
            res.Append(stack.Pop());
        }
        char[] charArray = res.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);

    }

    // public void Dfs(string s, string path, List<string> res, int idx, int uniques, int[] freq, bool[] visited)
    // {
    //     if (idx == s.Length)
    //     {
    //         // if (path.Length == uniques)
    //         //     res.Add(path);
    //         if (bestResult == null || string.CompareOrdinal(path, bestResult) < 0) {
    //             bestResult = path; 
    //         }
    //         return;
    //     }

    //     char c = s[idx];
    //     int charIdx = c - 'a';

    //     if (visited[charIdx]) {
    //         freq[charIdx]--;
    //         Dfs(s, path, res, idx + 1, uniques, freq, visited);
    //         freq[charIdx]++;
    //         return;
    //     }

    //     visited[charIdx] = true;
    //     freq[charIdx]--;
    //     Dfs(s, path + c, res, idx + 1, uniques, freq, visited);
    //     // Backtrack
    //     visited[charIdx] = false;
    //     freq[charIdx]++;

    //     if (freq[charIdx] > 1) {
    //         freq[charIdx]--; 
    //         Dfs(s, path, res, idx + 1, uniques, freq, visited);
    //         freq[charIdx]++; 
    //     }

    // }
}
// @lc code=end

