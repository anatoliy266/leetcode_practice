/*
 * @lc app=leetcode id=258 lang=csharp
 *
 * [258] Add Digits
 */

// @lc code=start
public class Solution {
    public int AddDigits(int num) {
        // while (num >= 10)
        // {
        //     var sum = 0;
        //     while (num > 0)
        //     {
        //         sum += num % 10;
        //         num = num / 10;
        //     }
        //     num = sum;
        // }
        // return num;

        if (num == 0) return 0;
        return 1 + (num - 1) % 9;
    }
}
// @lc code=end

