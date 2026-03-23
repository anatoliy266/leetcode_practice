/*
 * @lc app=leetcode id=212 lang=csharp
 *
 * [212] Word Search II
 */

// @lc code=start
using System.Diagnostics.CodeAnalysis;
using System.Text;

public class TrieNode()
{
    public TrieNode[] Childrens { get; set; } = new TrieNode[26];
    public bool IsWordEnd { get; set; }

}
public class Solution
{
    private (int,int)[] directions = new[] { (0, 1), (0, -1), (1, 0), (-1, 0) };
    private TrieNode root = new TrieNode();
    public IList<string> FindWords(char[][] board, string[] words)
    {
        foreach (var word in words)
        {
            var curr = root;
            foreach (var c in word)
            {
                var i = c - 'a';
                if (curr.Childrens[i] == null)
                {
                    curr.Childrens[i] = new TrieNode();
                }
                curr = curr.Childrens[i];
            }
            curr.IsWordEnd = true;
        }

        var seen = new bool[board.Length ,board[0].Length];

        var result = new List<string>(); 

        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[0].Length; j++)
            {
                BackTrack(root, board, i, j, seen, new StringBuilder(), result);
            }
        }
        return result;
    }

    private void BackTrack(TrieNode node, char[][] board, int i, int j, bool[,] seen, StringBuilder word, List<string> result)
    {
        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || seen[i, j]) 
            return;
        var idx = board[i][j] - 'a';
        if (node.Childrens[idx] == null) return;
        
        word.Append(board[i][j]);
        seen[i,j] = true;
        if (node.Childrens[idx].IsWordEnd)
        {
            result.Add(word.ToString());
            node.Childrens[idx].IsWordEnd = false;
        }

        for (var dirIdx = 0; dirIdx < directions.Length; dirIdx++)
        {
            var (dx, dy) = directions[dirIdx];
            var di = i + dx;
            var dj = j + dy;
            BackTrack(node.Childrens[idx], board, di, dj, seen, word, result);
        }
        seen[i,j] = false;
        word.Length--;
    }
}
// @lc code=end

