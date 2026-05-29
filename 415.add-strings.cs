/*
 * @lc app=leetcode id=415 lang=csharp
 *
 * [415] Add Strings
 */

// @lc code=start
using System.Text;

public class Solution {
    public string AddStrings(string num1, string num2) {
        var l = num1.Length > num2.Length ? num1.Length : num2.Length;
        var (d1,d2,l1,l2,extra) = (0,0, num1.Length -1, num2.Length-1,0);
        var res = new StringBuilder();
        
        while (l1 >= 0 || l2 >= 0 || extra > 0)
        {
            d1 = l1 >= 0 ? num1[l1]-'0' : 0;
            d2 = l2 >= 0 ? num2[l2] - '0' : 0;
            
            var d = extra + d1 + d2;
            extra = d / 10;        
            res.Insert(0, d % 10);   
            l1--;
            l2--;
        }
        if (extra > 0) res.Insert(0, 1);
        return res.ToString();
    }
}
// @lc code=end

