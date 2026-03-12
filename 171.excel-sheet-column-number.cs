/*
 * @lc app=leetcode id=171 lang=csharp
 *
 * [171] Excel Sheet Column Number
 */

// @lc code=start
using System.Globalization;

public class Solution {
    public int TitleToNumber(string columnTitle) {
        var mask = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var num = 0;
        for (var i = 0; i < columnTitle.Length; i++)
        {
            var d = mask.IndexOf(columnTitle[i]);
            num = num*26+d+1;
        }
        return num;



        
        
        // var mask = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        // var res = new List<char>();

        // while (columnNumber > 0)
        // {
        //     columnNumber--;
        //     var idx = columnNumber % 26;
        //     res.Add(mask[idx]);
        //     columnNumber /= 26;
        // }
        // //res.Add(mask[columnNumber]);
        // res.Reverse();
        // return new string(res.ToArray());
    }
}
// @lc code=end

