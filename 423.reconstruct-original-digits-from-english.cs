/*
 * @lc app=leetcode id=423 lang=csharp
 *
 * [423] Reconstruct Original Digits from English
 */

// @lc code=start
using System.Net.WebSockets;
using System.Text;
using System.Xml.Schema;
using Microsoft.VisualBasic;

public class Solution
{
    public string OriginalDigits(string s)
    {
        var sCounts = new int[26];
        for (var i = 0; i < s.Length; i++)
        {
            sCounts[s[i] - 'a']++;
        }

        var words = new string[] {"zero", "two", "four", "six", "eight", "three", "five", "seven", "one", "nine"};
        var digitValues = new int[] {0, 2, 4, 6, 8, 3, 5, 7, 1, 9};

       var finalDigitCounts = new int[10];

        var idx = 0;
        while (idx < words.Length)
        {
            var word = words[idx];
            var hasWord = true;

            Span<int> wordReq = stackalloc int[26];
            for (var j = 0; j < word.Length; j++)
            {
                wordReq[word[j] - 'a']++;
            }

            // Проверяем, хватает ли букв
            for (int j = 0; j < 26; j++)
            {
                if (sCounts[j] < wordReq[j])
                {
                    hasWord = false;
                    break;
                }
            }

            if (hasWord)
            {
                finalDigitCounts[digitValues[idx]]++;
                
                for (var j = 0; j < word.Length; j++)
                {
                    sCounts[word[j] - 'a']--;
                }
            }
            else
            {
                idx++;
            }
        }

        var res = new StringBuilder();
        for (int digit = 0; digit <= 9; digit++)
        {
            if (finalDigitCounts[digit] > 0)
            {
                res.Append((char)('0' + digit), finalDigitCounts[digit]);
            }
        }

        return res.ToString();
    }
}
// @lc code=end

