/*
 * @lc app=leetcode id=208 lang=csharp
 *
 * [208] Implement Trie (Prefix Tree)
 */

// @lc code=start
public class TrieNode
{
    public char val { get; set; }
    public TrieNode[] Childrens { get; set; } = new TrieNode[26];
    public bool isWordEnd { get; set; }
}

public class Trie
{
    private TrieNode _root { get; set; }
    public Trie()
    {
        _root = new TrieNode();
    }

    public void Insert(string word)
    {
        // if (!TrieNodes.ContainsKey(word[0]))
        // {
        //     var root = new TrieNode();
        //     root.val = word[0];
        //     TrieNodes[word[0]] = root;
        // }

        // var curr = TrieNodes[word[0]];
        // for (var i = 1; i < word.Length; i++)
        // {
        //     var next = curr.Childrens.FirstOrDefault(x => x.val == word[i]);
        //     if (next == null) {
        //         next = new TrieNode { 
        //             val = word[i], 
        //             Childrens = new List<TrieNode>() 
        //         };
        //         curr.Childrens.Add(next);
        //     }
        //     curr = next;
        // }
        // curr.isWordEnd = true;

        var curr = _root;
        foreach (var c in word)
        {
            var idx = c - 'a';
            if (curr.Childrens[idx] == null)
            {
                curr.Childrens[idx] = new TrieNode();
                curr.Childrens[idx].val = c;
            }
            curr = curr.Childrens[idx];
        }
        curr.isWordEnd = true;
    }

    public bool Search(string word)
    {
        // if (!TrieNodes.ContainsKey(word[0])) return false;
        // var root = TrieNodes[word[0]];
        // var curr = root;
        // for (var i = 1; i < word.Length; i++)
        // {
        //     var next = curr.Childrens.FirstOrDefault(x => x.val == word[i]);
        //     if (next == null) return false;
        //     curr = next;
        // }
        // return curr.isWordEnd == true;

        var curr = _root;
        foreach (var c in word)
        {
            var idx = c - 'a';
            if (curr.Childrens[idx] == null) return false;
            curr = curr.Childrens[idx];
        }
        return curr.isWordEnd;
    }

    public bool StartsWith(string prefix)
    {
        // if (!TrieNodes.ContainsKey(prefix[0])) return false;
        // var root = TrieNodes[prefix[0]];
        // var curr = root;
        // for (var i = 1; i < prefix.Length; i++)
        // {
        //     var next = curr.Childrens.FirstOrDefault(x => x.val == prefix[i]);
        //     if (next == null) return false;
        //     curr = next;
        // }
        // return true;
        

        var curr = _root;
        foreach (var c in prefix)
        {
            var idx = c - 'a';
            if (curr.Childrens[idx] == null) return false;
            curr = curr.Childrens[idx];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
// @lc code=end

