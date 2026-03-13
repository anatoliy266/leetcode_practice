/*
 * @lc app=leetcode id=168 lang=csharp
 *
 * [168] Excel Sheet Column Title
 */

// @lc code=start
using System.Net.Security;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        var mask = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var res = new List<char>();

        while (columnNumber > 0)
        {
            columnNumber--;
            var idx = columnNumber % 26;
            res.Add(mask[idx]);
            columnNumber /= 26;
        }
        //res.Add(mask[columnNumber]);
        res.Reverse();
        return new string(res.ToArray());

        // var quot = columnNumber / 26; //80000000
        // if (quot != 0) sb.Append(mask[quot]);


        // var rem = columnNumber % 26;
        // while (rem > 26)
        // {
        //     sb.Append(mask[rem / 26]);
        //     rem = rem % 26;
        // }
        // sb.Append(mask[rem]);
        // return sb.ToString();
    }
}
// @lc code=end

