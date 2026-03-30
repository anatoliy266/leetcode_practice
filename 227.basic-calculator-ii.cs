/*
 * @lc app=leetcode id=227 lang=csharp
 *
 * [227] Basic Calculator II
 */

// @lc code=start
public class Solution
{
    public int Calculate(string s)
    {
        var res = 0;
        var num = 0;
        var lastTerm = 0; 
        var op = '+';
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (c >= '0' && c <= '9')
            {
                num = num*10 + (c-'0');
            }
            if ((!(c >= '0' && c <= '9') && c != ' ') || i == s.Length-1)
            {
                if (op == '+')
                {
                    res += lastTerm;
                    lastTerm = num;
                }
                else if (op == '-')
                {
                    res += lastTerm;
                    lastTerm = -num;
                }
                else if (op == '*') {
                    lastTerm = lastTerm*num;
                }
                else if (op == '/') {
                    lastTerm = lastTerm/num;
                }

                op = c;
                num = 0; 
            }
        }
        return res + lastTerm;
    }
}
// @lc code=end

