/*
 * @lc app=leetcode id=211 lang=csharp
 *
 * [211] Design Add and Search Words Data Structure
 */

// @lc code=start
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
public class TrieNode()
{
    public bool IsWordEnd{get; set;}
    public TrieNode[] Childrens {get; set;} = new TrieNode[26];
}

public class WordDictionary {
    private TrieNode root = new TrieNode();
    public WordDictionary() {
        
    }
    
    public void AddWord(string word) {
        var curr = root;
        foreach (var c in word)
        {
            var i = c - 'a';
            if (curr.Childrens[i] == null) {
                curr.Childrens[i] = new TrieNode();
            }
            curr = curr.Childrens[i];
        }
        curr.IsWordEnd = true;
    }
    
    public bool Search(string word) {
        return BackTrack(root, 0, word);
    }

    private bool BackTrack(TrieNode node, int idx, string word)
    {
        if (idx == word.Length) return node.IsWordEnd;

        if (word[idx] == '.')
        {
            for (var i = 0; i < node.Childrens.Length; i++)
            {
                if (node.Childrens[i] != null && BackTrack(node.Childrens[i], idx+1, word)) return true;
            }
        }
        else
        {
            var i = word[idx] - 'a';
            if (node.Childrens[i] == null) return false;
            return BackTrack(node.Childrens[i], idx+1, word);
        }
        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
// @lc code=end

