/*
 * @lc app=leetcode id=472 lang=csharp
 *
 * [472] Concatenated Words
 */

// @lc code=start

public class TrieNode
{
    public TrieNode[] Children;

    // Флаг конца слова
    public bool EndOfWord;

    public TrieNode()
    {
        Children = new TrieNode[26];
        EndOfWord = false;
    }
}
public class Solution
{
    public bool DFS(string word, int i, TrieNode root, bool?[] memo)
    {
        if (i == word.Length) return true;
        if (memo[i].HasValue) return memo[i].Value;

        var curr = root;
        for (var j = i; j < word.Length; j++)
        {
            var idx = word[j] - 'a';
            curr = curr.Children[idx];
            if (curr is null) break;
            if (curr.EndOfWord)
            {
                if (DFS(word, j + 1, root, memo)) return true;
            }
        }
        memo[i] = false; 
        return false;
    }

    public IList<string> FindAllConcatenatedWordsInADict(string[] words)
    {
        var root = new TrieNode();
        foreach (var word in words)
        {
            var curr = root;
            foreach (var c in word)
            {
                var idx = c - 'a';
                if (curr.Children[idx] is null) curr.Children[idx] = new TrieNode();
                curr = curr.Children[idx];
            }
            curr.EndOfWord = true;
        }

        var res = new List<string>();
        foreach (var word in words)
        {
            if (string.IsNullOrEmpty(word)) continue;
            
            var curr = root;
            foreach (var c in word) curr = curr.Children[c - 'a'];
            curr.EndOfWord = false;

            var memo = new bool?[word.Length];

            if (DFS(word, 0, root, memo)) res.Add(word);
            curr.EndOfWord = true;
        }

        return res;
    }
}
// @lc code=end

