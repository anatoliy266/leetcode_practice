/*
 * @lc app=leetcode id=481 lang=csharp
 *
 * [481] Magical String
 */

// @lc code=start
public class Solution {
    public int MagicalString(int n) {
        if (n <= 0) return 0;
        if (n <= 3) return 1;

        var s = new int[n + 1];
        s[0] = 1;
        s[1] = 2;
        s[2] = 2;

        var head = 2; 
        var tail = 3;
        var num = 1;
        var countOfOnes = 1;

        while (tail < n) {
            var repeats = s[head];
            
            for (var i = 0; i < repeats && tail < n; i++) {
                s[tail] = num;
                if (num == 1) {
                    countOfOnes++;
                }
                tail++;
            }
            
            num = 3 - num; 
            head++;
        }

        return countOfOnes;
    }
}
// @lc code=end

