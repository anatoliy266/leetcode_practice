/*
 * @lc app=leetcode id=443 lang=csharp
 *
 * [443] String Compression
 */

// @lc code=start
using System.Runtime.InteropServices.Marshalling;

public class Solution
{
    public int Compress(char[] chars)
    {
        var (slow, fast) = (0, 0);
        
        while (fast < chars.Length)
        {
            var groupCnt = 0;
            var current = chars[fast];
            
            while (fast < chars.Length && chars[fast] == current)
            {
                groupCnt++;
                fast++;
            }

            chars[slow++] = current;

            if (groupCnt > 1)
            {
                var groupStr = groupCnt.ToString();
                for (var i = 0; i < groupStr.Length; i++)
                {
                    chars[slow++] = groupStr[i];
                }
            }
            
        }
        return slow;
    }
}
// @lc code=end

