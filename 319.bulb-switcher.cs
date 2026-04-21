/*
 * @lc app=leetcode id=319 lang=csharp
 *
 * [319] Bulb Switcher
 */

// @lc code=start
public class Solution {
    public int BulbSwitch(int n) {
        // if (n <= 0) return 0;
        // var lights = new int[n];
        // for (var i = 1; i <= n; i++)
        // {
        //     for (var j = i-1; j < n; j += i)
        //     {
        //         lights[j]++;
        //     }
        // }
        // var cnt = 0;
        // for (var i = 0; i < n; i++)
        // {
        //     if (lights[i] % 2 != 0) cnt++;
        // }
        // return cnt;

        return (int)Math.Sqrt(n);
    }

}
// @lc code=end

