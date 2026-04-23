/*
 * @lc app=leetcode id=326 lang=csharp
 *
 * [326] Power of Three
 */

// @lc code=start
public class Solution {
    public bool IsPowerOfThree(int n) {
        // if (Math.Log(n, 3) % 1 != 0) return false;
        // else return true;

        if (n <=0) return false;

        while (n % 3 == 0) n/=3;
        return n == 1;
    }
}
// @lc code=end

