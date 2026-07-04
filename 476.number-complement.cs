/*
 * @lc app=leetcode id=476 lang=csharp
 *
 * [476] Number Complement
 */

// @lc code=start
public class Solution
{
    public int FindComplement(int num)
    {
        int bitLength = Convert.ToString(num, 2).Length;
        int mask = (1 << bitLength) - 1;
        return num ^ mask;
    }
}
// @lc code=end

