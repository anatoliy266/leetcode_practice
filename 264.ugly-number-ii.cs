/*
 * @lc app=leetcode id=264 lang=csharp
 *
 * [264] Ugly Number II
 */

// @lc code=start
public class Solution
{
    public int NthUglyNumber(int n)
    {
        // var list = new SortedSet<long>() {1};
        // var cnt = 0;
        // while (cnt < n-1)
        // {
        //     var val = list.Min;
        //     list.Add(val * 2);
        //     list.Add(val * 3);
        //     list.Add(val * 5);
        //     list.Remove(list.Min);
        //     cnt++;
        // }
        // return (int)list.Min;


        // var cnt = 0;
        // var i = 0;
        // do
        // {
        //     if (IsUgly(i)) cnt++;
        //     i++;
        // }while (cnt != n);
        // return i-1;


        var dp = new int[n];
        dp[0] = 1;
        var (i2, i3, i5) = (0, 0, 0);
        var (next2, next3, next5) = (2, 3, 5);
        for (var i = 1; i < n; i++)
        {
            dp[i] = Math.Min(next2, Math.Min(next3, next5));

            if (dp[i] == next2) { i2++; next2 = dp[i2] * 2; }
            if (dp[i] == next3) { i3++; next3 = dp[i3] * 3; }
            if (dp[i] == next5) { i5++; next5 = dp[i5] * 5; }
        }
        return dp[n - 1];

    }

    // public bool IsUgly(int n) {
    //     if (n <= 0) return false;
    //     while (n % 2 == 0) n = n / 2;
    //     while (n % 3 == 0) n = n / 3;
    //     while (n % 5 == 0) n = n / 5;
    //     return n == 1;
    // }
}
// @lc code=end

