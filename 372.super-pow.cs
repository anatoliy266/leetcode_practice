/*
 * @lc app=leetcode id=372 lang=csharp
 *
 * [372] Super Pow
 */

// @lc code=start
public class Solution
{
    public int SuperPow(int a, int[] b)
    {
        // var c = 0;
        // for (var i = 0; i < b.Length; i++)
        // {
        //     c = c*10 + b[i];
        // }
        // a = a % 1337;
        // return (int)Math.Pow(a,c);
        var res = 1;
        for (var i = 0; i < b.Length; i++)
        {
            res = (int)((long)MyPow(res, 10) * MyPow(a, b[i]) % 1337);
        }
        return res;
    }

    private int MyPow(int x, int n)
    {
        int r = 1;
        x %= 1337;
        for (int i = 0; i < n; i++)
        {
            r = (r * x) % 1337;
        }
        return r;
    }
}
// @lc code=end

