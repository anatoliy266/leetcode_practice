/*
 * @lc app=leetcode id=127 lang=csharp
 *
 * [127] Word Ladder
 */

// @lc code=start
public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        // var queue = new Queue<string>();
        // var visited = new HashSet<string>();
        // var wordSet = wordList.ToHashSet();
        // var lvl = 1;

        // if (!wordSet.Contains(endWord)) return 0;
        // queue.Enqueue(beginWord);
        // visited.Add(beginWord);

        // while (queue.Count > 0)
        // {
        //     lvl++;
        //     var temp = new List<string>();
        //     var qL = queue.Count();
        //     for (var q = 0; q < qL; q++)
        //     {
        //         var w = queue.Dequeue().ToCharArray();
        //         for (var i = 0; i < w.Length; i++)
        //         {
        //             var oldW = w[i];
        //             for (var j = 'a'; j <= 'z'; j++)
        //             {
        //                 w[i] = j;
        //                 var nW = new string(w);
        //                 if (nW == endWord) return lvl;
        //                 if (wordSet.Contains(nW) && !visited.Contains(nW))
        //                 {
        //                     temp.Add(nW);
        //                     queue.Enqueue(nW);
        //                 }
        //             }
        //             w[i] = oldW;
        //         }
        //     }
        //     if (temp.Count == 0) return 0;
        //     foreach (var ww in temp) visited.Add(ww);
        // }
        // return lvl;



        var wordSet = wordList.ToHashSet();
        if (!wordSet.Contains(endWord)) return 0;

        var startSet = new HashSet<string> { beginWord };
        var endSet = new HashSet<string> { endWord };

        var lvl = 1;

        while (startSet.Count > 0 && endSet.Count > 0)
        {
            if (startSet.Count > endSet.Count)
            {
                var temp = startSet;
                startSet = endSet;
                endSet = temp;
            }
            var next = new HashSet<string>();
            foreach (var word in startSet)
            {
                
                var w = word.ToCharArray();
                for (var i = 0; i < w.Length; i++)
                {
                    var oldW = w[i];
                    for (var j = 'a'; j <= 'z'; j++)
                    {
                        if (j == oldW) continue;
                        w[i] = j;
                        var nW = new string(w);
                        if (endSet.Contains(nW)) return lvl+1;
                        if (wordSet.Contains(nW))
                        {
                            next.Add(nW);
                            wordSet.Remove(nW);
                        }
                    }
                    w[i] = oldW;
                }
            }
            if (next.Count == 0) return 0;
            startSet = next;
            lvl++;
        }
        return lvl;
    }
}
// @lc code=end

