/*
 * @lc app=leetcode id=126 lang=csharp
 *
 * [126] Word Ladder II
 */

// @lc code=start
using Microsoft.VisualBasic;

public class Solution
{
    //Dictionary<int, List<IList<string>>> dict = new Dictionary<int, List<IList<string>>>();
    
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        var visited = new Dictionary<string, int>();
        var parents = new Dictionary<string, List<string>>();
        var wordSet = wordList.ToHashSet();
        var queue = new Queue<string>();
        queue.Enqueue(beginWord);
        visited[beginWord] = 1;
        var lvl = 1;
        var end = false;
        
        while (queue.Count > 0 && !end)
        {
            var qL = queue.Count;
            for (var q = 0; q < qL; q++)
            {
                var w = queue.Dequeue();

                var cW = w.ToCharArray();
                for (var i = 0; i < cW.Length; i++)
                {
                    var oldLetter = cW[i];
                    for (var j = 'a'; j <= 'z'; j++)
                    {
                        cW[i] = j;
                        var nW = new string(cW);
                        if (wordSet.Contains(nW))
                        {
                            if (nW == endWord) end = true;
                            if (!visited.ContainsKey(nW))
                            {
                                visited[nW] = lvl + 1;
                                parents[nW] = new List<string>() { w };
                                queue.Enqueue(nW);
                                if (nW == endWord) end = true;
                            }
                            
                            else if (visited[nW] == lvl + 1)
                            {
                                parents[nW].Add(w);
                            }
                        }
                    }
                    cW[i] = oldLetter;
                }
            }
            lvl++;
        }
        var result = new List<IList<string>>();
        if (parents.ContainsKey(endWord))
            Backtrack(endWord, beginWord, parents, new List<string>() {endWord}, result);
        return result;
        // var wordSet = wordList.ToHashSet();
        // if (!wordSet.Contains(endWord)) return result;
        // Dfs(new List<string>() { beginWord }, endWord, wordSet, new List<string>());
        // return result;
    }

    public void Backtrack(string beginWord, string endWord, Dictionary<string, List<string>> parents, List<string> path, List<IList<string>> result)
    {
        if (beginWord == endWord)
        {
            var res = new List<string>(path);
            res.Reverse();
            result.Add(res);
        }
        if (!parents.ContainsKey(beginWord)) return;
        var l = parents[beginWord];
        for (var i = 0; i < l.Count; i++)
        {
            path.Add(l[i]);
            Backtrack(l[i], endWord, parents, path, result);
            path.RemoveAt(path.Count-1);
        }
    }

    // public void Dfs(IList<string> beginWords, string endWord, HashSet<string> wordList, List<string> list)
    // {
    //     if (result.Count > 0 && list.Count >= result[0].Count) return;

    //     if (beginWords.Contains(endWord))
    //     {
    //         list.Add(endWord);
    //         if (result.Count > 0 && list.Count < result[0].Count) result.Clear();

    //         result.Add(new List<string>(list));
    //         list.RemoveAt(list.Count - 1);
    //         return;
    //     }
    //     foreach (var w in beginWords) wordList.Remove(w);
    //     foreach (var w in beginWords)
    //     {
    //         var nextWords = new List<string>();
    //         var cW = w.ToCharArray();
    //         for (var i = 0; i < cW.Length; i++)
    //         {
    //             var oldLetter = cW[i];
    //             for (var j = 'a'; j <= 'z'; j++)
    //             {
    //                 cW[i] = j;
    //                 if (wordList.Contains(new string(cW))) nextWords.Add(new string(cW));
    //             }
    //             cW[i] = oldLetter;
    //         }
    //         if (nextWords.Count == 0) continue;
    //         list.Add(w);
    //         Dfs(nextWords, endWord, new HashSet<string>(wordList), list);
    //         list.RemoveAt(list.Count - 1);
    //     }
    // }
}
// @lc code=end

