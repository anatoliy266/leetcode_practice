/*
 * @lc app=leetcode id=393 lang=csharp
 *
 * [393] UTF-8 Validation
 */

// @lc code=start
public class Solution {
    public bool ValidUtf8(int[] data) {
        var remainingBytes = 0;
        var b = 0x88;
        for (var i = 0; i < data.Length; i++)
        {
            b = data[i] & 0xFF;
            if (remainingBytes == 0)
            {
                if ((b & 0x80) == 0) continue;
                else if ((b & 0xE0) == 0xC0) remainingBytes = 1;
                else if ((b & 0xF0) == 0xE0) remainingBytes = 2;
                else if ((b & 0xF8) == 0xF0) remainingBytes = 3;
                else return false;
            } else
            {
                if ((b & 0xC0) != 0x80) return false;
                remainingBytes--;
            }
        }
        return remainingBytes == 0;
    }

    
    // 8 = 1000 C = 1100 E = 1110 F = 1111
}
// @lc code=end

