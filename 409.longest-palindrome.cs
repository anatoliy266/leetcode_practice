/*
 * @lc app=leetcode id=409 lang=csharp
 *
 * [409] Longest Palindrome
 */

// @lc code=start
public class Solution
{
    public int LongestPalindrome(string s)
    {
        // var dict = new Dictionary<char, int>();

        // var odd = false;
        // var count = 0;

        // for (var i = 0; i < s.Length; i++)
        // {
        //     if (dict.ContainsKey(s[i])) dict[s[i]]++;
        //     else dict[s[i]] = 1;
        // }


        // foreach (var kvp in dict)
        // {
        //     count += (kvp.Value / 2) * 2;
        //     if (kvp.Value % 2 != 0) odd = true;
        // }
        // return odd ? count + 1 : count;

        var count = 0;

        // var set = new HashSet<char>();
        var arr = new bool[128];
        for (var i = 0; i < s.Length; i++)
        {
            // if (!set.Add(s[i]))
            if (arr[s[i]])
            {
                arr[s[i]] = false;
                count += 2;
            } else
            {
                arr[s[i]] = true;
            }
            
        }
        // if (set.Count > 0) count += 1;
        if (count < s.Length) count +=1;
        return count;
    }
}
// @lc code=end
