/*
 * @lc app=leetcode id=204 lang=csharp
 *
 * [204] Count Primes
 */

// @lc code=start
public class Solution {
    public int CountPrimes(int n) {
        if (n <= 2) return 0;
        var seen = new bool[n];
        for (var i =3; i < n; i+=2) seen[i] = true;
        for (var i = 3; i * i < n; i+=2)
        {
            if (!seen[i]) continue;
            for (var j = i*i; j < n; j+= 2*i)
            {
                seen[j] = false;
            }
        }
        var cnt = 1;
        for (var i = 3; i < n; i+=2)
        {
            if (seen[i]) cnt++;
        }
        return cnt;
    }
}
// @lc code=end

