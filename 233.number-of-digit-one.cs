/*
 * @lc app=leetcode id=233 lang=csharp
 *
 * [233] Number of Digit One
 */

// @lc code=start
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Solution {
    Dictionary<int, int> memo = new Dictionary<int, int>();
    public int CountDigitOne(int n) {
        // var cnt = 0;
        
        // for (var i = 1; i<=n; i++)
        // {
        //     var sn = i.ToString();
        //     foreach (var c in sn)
        //     {
        //         if (c == '1') cnt++;
        //     }
        // }
        // return cnt;

        if (n <= 0) return 0;
        if (n < 10) return 1;
        if (memo.TryGetValue(n, out var val)) return val;

        int c = (int)Math.Log10(n);
        var k = (int)Math.Pow(10, c);

        var head = n / k;
        var tail = n % k;
        var cnt = 0;
        if (head == 1) cnt += tail+1 + head*CountDigitOne(k-1);
        else
        {
            cnt +=  k+head*CountDigitOne(k-1);
        } 
        var res = cnt + CountDigitOne(tail);
        memo[n] = res;
        return res;
    }
}
// @lc code=end

