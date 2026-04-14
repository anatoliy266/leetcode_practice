/*
 * @lc app=leetcode id=299 lang=csharp
 *
 * [299] Bulls and Cows
 */

// @lc code=start
using System.ComponentModel.DataAnnotations;
using System.Text;

public class Solution
{
    public string GetHint(string secret, string guess)
    {
        // 1 2 3 4
        // 1 2 1 5
        var (a, b) = (0, 0);
        // var dict = new Dictionary<int, int>();
        var list = new int[10];
        for (var i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i]) a++;
            else
            {
                var s = secret[i] - '0';
                var g = guess[i] - '0';
                if (list[s] < 0) b++;
                if (list[g] > 0) b++;

                list[s]++;
                list[g]--;
            }
        }
        // return new StringBuilder().Append(a).Append("A").Append(b).Append("B").ToString();
        return $"{a}A{b}B";
    }
}
// @lc code=end

