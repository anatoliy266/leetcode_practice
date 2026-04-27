/*
 * @lc app=leetcode id=336 lang=csharp
 *
 * [336] Palindrome Pairs
 */

// @lc code=start
using System.Reflection.Emit;

public class Solution
{
    public IList<IList<int>> PalindromePairs(string[] words)
    {
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

        // var dict = new Dictionary<string, int>();
        // for (var i = 0; i < words.Length; i++)
        // {
        //     char[] arr = words[i].ToCharArray();
        //     Array.Reverse(arr);
        //     dict[new string(arr)] = i;
        // }

        // var res = new List<IList<int>>();

        // for (var i = 0; i < words.Length; i++)
        // {
        //     var word = words[i].AsSpan();
        //     for (var j = 0; j <= word.Length; j++)
        //     {

        //         if (IsPalindrome(word, 0, j-1))
        //         {
        //             var left = word.Slice(j);
        //             if (dict.TryGetValue(left.ToString(), out var idx1) && idx1 != i) res.Add(new List<int>{idx1, i});
        //         }
        //         if (j < word.Length && IsPalindrome(word, j, word.Length-1))
        //         {
        //             var right = word.Slice(0, j);
        //             if (dict.TryGetValue(right.ToString(), out var idx2) && idx2 != i) res.Add(new List<int>{i, idx2});
        //         }
        //     }
        // }
        // return res;
        var res = new List<IList<int>>();

        long m = 1000000009;
        long p = 31;

        var pow = new long[301];
        pow[0] = 1;
        for (var i = 1; i < pow.Length; i++)
        {
            pow[i] = pow[i - 1] * p  % m;
        }


        var dict = new Dictionary<long, int>();
        for (var i = 0; i < words.Length; i++)
        {
            long h = 0;
            for (var j = words[i].Length - 1; j >= 0; j--)
            {
                h = (h * p + (words[i][j] - 'a' + 1)) % m;
            }
            dict[h] = i;
        }

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];
            var sums = new long[word.Length + 1];
            for (var j = 0; j < word.Length; j++)
            {
                sums[j + 1] = (sums[j] * p + (word[j] - 'a' + 1)) % m;
            }

            for (var j = 0; j <= word.Length; j++)
            {
                if (IsPalindrome(word, 0, j - 1))
                {
                    long suffHash = (sums[word.Length] - (sums[j] * pow[word.Length - j] % m) + m) % m;
                    if (dict.TryGetValue(suffHash, out var idx) && idx != i)
                    {
                        if (IsReverse(words[idx], word, j, word.Length - 1))
                            res.Add(new List<int> { idx, i });
                    }
                }
                if (j < word.Length && IsPalindrome(word, j, word.Length - 1))
                {
                    if (dict.TryGetValue(sums[j], out var idx) && idx != i)
                    {
                        if (IsReverse(words[idx], word, 0, j - 1))
                            res.Add(new List<int> { i, idx });
                    }
                }
            }
        }
        return res;
    }

    private bool IsReverse(string s1, string s2, int start, int end) {
        if (s1.Length != (end - start + 1)) return false;
        for (int i = 0; i < s1.Length; i++)
            if (s1[i] != s2[end - i]) return false;
        return true;
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

