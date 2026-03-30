/*
 * @lc app=leetcode id=224 lang=csharp
 *
 * [224] Basic Calculator
 */

// @lc code=start
using System.Diagnostics.CodeAnalysis;

public class Solution
{
    public int Calculate(string s)
    {
        var stack = new Stack<(int, int)>();
        var res = 0;
        var num = 0;
        var sign = 1;
        for (var i = 0; i < s.Length; i++)
        {

            var c = s[i];
            if (c >= '0' && c <= '9')
            {
                num = num * 10 + (c - '0');
            }
            else if (s[i] == ')')
            {
                res += num * sign;
                num = 0;
                var (prevRes, prevSign) = stack.Pop();
                res = res * prevSign + prevRes;
            }
            else if (s[i] == '(')
            {
                stack.Push((res, sign));
                res = 0;
                sign = 1;
            }
            else if (s[i] == '+')
            {
                res += num * sign;
                sign = 1;
                num = 0;
            }
            else if (s[i] == '-')
            {
                res += num * sign;
                sign = -1;
                num = 0;
            }
        }
        return res + num * sign;
    }
}
// @lc code=end

