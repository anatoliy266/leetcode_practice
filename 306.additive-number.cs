/*
 * @lc app=leetcode id=306 lang=csharp
 *
 * [306] Additive Number
 */

// @lc code=start
using System.Reflection.PortableExecutable;

public class Solution {
    public bool IsAdditiveNumber(string num) {
        if (num.Length < 3) return false;
        // var isAdditive = true;
        // for (var i = 1; i < num.Length; i++)
        // {
        //     for (var j = i+1; j < num.Length; j++)
        //     {
        //         var a = int.Parse(num.Substring(0, i));
        //         var b = int.Parse(num.Substring(i, j));
        //         var c = int.Parse(num.Substring(j));
        //         if (a +  b != c) {isAdditive = false; break;}
        //     }
        //     if (!isAdditive) break;
        // }
        // return isAdditive;
        var spanNum = num.AsSpan();
        for (var i = 1; i <= num.Length/2; i++)
        {
            for (var j = 1; Math.Max(i, j) <= num.Length - i - j; j++)
            {
                if (IsAdditive(spanNum.Slice(0, i), spanNum.Slice(i, j), spanNum.Slice(i+j))) return true;
            }
        }
        return false;
    }

    private bool IsAdditive(ReadOnlySpan<char> a, ReadOnlySpan<char> b, ReadOnlySpan<char> rest)
    {
        if ((a.Length > 1 && a[0] == '0') || (b.Length > 1 && b[0] == '0')) return false;
        if (!long.TryParse(a, out var aa) || !long.TryParse(b, out var bb)) return false;

        var sum  = (aa + bb).ToString().AsSpan();

        if (rest.SequenceEqual(sum)) return true;
        // if (!num.StartsWith(sum)) return false;
        // return IsAdditive(b, sum, num.Substring(sum.Length));
        if (rest.StartsWith(sum)) {
            return IsAdditive(b, sum, rest.Slice(sum.Length));
        }

        return false;
    }


}
// @lc code=end

