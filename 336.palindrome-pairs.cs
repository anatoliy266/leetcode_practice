/*
 * @lc app=leetcode id=336 lang=csharp
 *
 * [336] Palindrome Pairs
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> PalindromePairs(string[] words) {
        // var res = new List<IList<int>>();
        // var memo = new HashSet<(int, int)>();
        // for (var i = 0; i < words.Length; i++)
        // {
        //     for (var j = 0; j < words.Length; j++)
        //     {
        //         if (i == j) continue;
        //         var word = words[i] + words[j];
        //         var (l,r) = (0, word.Length-1);
        //         var isPal =true;
        //         while (l <= r)
        //         {
        //             if (word[l++] != word[r--]) {isPal = false; break;}
        //         }
        //         if (isPal && memo.Add((i,j))) res.Add(new List<int>{i, j});
        //     }
        // }
        // return res;
        var dict = new Dictionary<string, int>();
        for (var i = 0; i < words.Length; i++)
        {
            char[] arr = words[i].ToCharArray();
            Array.Reverse(arr);
            dict[new string(arr)] = i;
        }

        var res = new List<IList<int>>();

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i].AsSpan();
            for (var j = 0; j <= words[i].Length; j++)
            {
                
                if (IsPalindrome(word, 0, j-1))
                {
                    var left = word.Slice(j);
                    if (dict.TryGetValue(left.ToString(), out var idx1) && idx1 != i) res.Add(new List<int>{idx1, i});
                }
                if (j < word.Length && IsPalindrome(word, j, word.Length-1))
                {
                    var right = word.Slice(0, j);
                    if (dict.TryGetValue(right.ToString(), out var idx2) && idx2 != i) res.Add(new List<int>{i, idx2});
                }
            }
        }
        return res;
    }

    private bool IsPalindrome(ReadOnlySpan<char> s, int i, int j)
    {
        while (i <= j)
        {
            if (s[i++] != s[j--]) return false;
        }
        return true;
    }
}
// @lc code=end

