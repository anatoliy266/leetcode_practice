/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>();
        for (var i = 0; i < numRows; i++)
        {
            var list = new List<int>();
            for (var j = 0; j<=i; j++)
            {
                if (j == 0 || j == i) list.Add(1);
                else
                {
                    list.Add(result[i-1][j-1]+result[i-1][j]);
                }
            }
            result.Add(new List<int>(list));
        }
        return result;
    }
}
// @lc code=end

