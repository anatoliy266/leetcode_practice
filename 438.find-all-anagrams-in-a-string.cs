/*
 * @lc app=leetcode id=438 lang=csharp
 *
 * [438] Find All Anagrams in a String
 */

// @lc code=start
public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var res = new List<int>();
        if (s.Length < p.Length) return res;

        var quantS = new int[26];
        var quantP = new int[26];

        for (var i = 0; i < p.Length; i++)
        {
            quantP[p[i] - 'a']++;
            quantS[s[i] - 'a']++;
        }

        // if (quantS.SequenceEqual(quantP))
        if (ArraysEqual(quantS, quantP))
        {
            res.Add(0);
        }

        var (l, r) = (0, p.Length);


        while (r < s.Length)
        {
            quantS[s[r] - 'a']++;
            quantS[s[l] - 'a']--;

            // if (quantS.SequenceEqual(quantP))
            if (ArraysEqual(quantS, quantP))
            {
                res.Add(l + 1);
            }

            l++;
            r++;
        }

        return res;
    }

    private bool ArraysEqual(int[] a, int[] b)
    {
        for (var i = 0; i < 26; i++)
        {
            if (a[i] != b[i]) return false;
        }
        return true;
    }
}
// @lc code=end

