/*
 * @lc app=leetcode id=166 lang=csharp
 *
 * [166] Fraction to Recurring Decimal
 */

// @lc code=start
using System.Text;

public class Solution
{
    public string FractionToDecimal(int numerator, int denominator)
    {
        if (numerator == 0) return "0";
        var dict = new Dictionary<long, int>();
        var sb = new StringBuilder();

        if ((numerator < 0) ^ (denominator < 0)) sb.Append("-");
        var num = Math.Abs((long)numerator);
        var den = Math.Abs((long)denominator);

        long d = num / den;
        sb.Append($"{d}");

        long dd = num % den;
        if (dd == 0) return sb.ToString();
        sb.Append(".");


        while (dd != 0)
        {
            if (dict.ContainsKey(dd))
            {
                sb.Insert(dict[dd], "(");
                sb.Append(")");
                return sb.ToString();
            }
            dict[dd] = sb.Length;

            d = dd * 10 / den;
            dd = dd * 10 % den;
            
            sb.Append(d.ToString());
        }
        return sb.ToString();
    }
}
// @lc code=end

