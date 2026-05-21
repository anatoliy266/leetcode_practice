/*
 * @lc app=leetcode id=405 lang=csharp
 *
 * [405] Convert a Number to Hexadecimal
 */

// @lc code=start
using System.Text;

public class Solution {
    public string ToHex(int num) {
        if (num == 0) return "0";
        var s = "0123456789abcdef";
        var sb = new StringBuilder();
        while (num != 0)
        {
            var mask = 0xF;
            var d = num & mask;
            sb.Insert(0, s[d]); 
            num >>>= 4;
        }
        return sb.ToString();
    }
}
// @lc code=end

        //0 = 0000
        // 1 = 0001
        // 2 = 0010
        // 3 = 0011
        // 4 = 0100
        // 5 = 0101
        // 6 = 0110
        // 7 = 0111
        // 8 = 1000
        // 9 = 1001
        // a = 1010
        // b = 1011
        // c = 1100 
        // d = 1101
        // e = 1110
        // f = 1111