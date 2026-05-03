/*
 * @lc app=leetcode id=367 lang=csharp
 *
 * [367] Valid Perfect Square
 */

// @lc code=start
public class Solution {
    public bool IsPerfectSquare(int num) {
        // for (var i = 1; i *i <= num; i++)
        // {
        //     if (i*i == num) return true;
        // }
        // return false;
        if (num < 1) return false;
        if (num == 1) return true;
        var (l,r) = (1, num);

        while (l < r)
        {
            
            var mid = l + (r-l) /2;
            var sq = (long)mid*mid;

            if (sq == num) return true; 
            if (sq > num) r = mid;
            else l = mid+1;

            // if (mid != 0 && num / mid == mid && num % mid == 0) return true; 
            // if (mid > num / mid) r = mid;
            // else l = mid+1;
        }
        return false;
    }
}
// @lc code=end

