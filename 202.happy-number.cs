/*
 * @lc app=leetcode id=202 lang=csharp
 *
 * [202] Happy Number
 */

// @lc code=start
public class Solution {
    public bool IsHappy(int n) {
        var hash = new HashSet<int>();
        while (true)
        {
            var sum = 0;
            var i = n;
            while (i > 0)
            {
                int d = i % 10;
                // sum += (int)Math.Pow(i % 10, 2);   
                sum += d*d;             
                i /= 10;   
            }
            if (sum == 1) return true;
            if (!hash.Add(sum)) return false;
            n = sum;
        }
        return false;
    }
}
// @lc code=end

