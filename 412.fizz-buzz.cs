/*
 * @lc app=leetcode id=412 lang=csharp
 *
 * [412] Fizz Buzz
 */

// @lc code=start
using System.Text;

public class Solution {
    public IList<string> FizzBuzz(int n) {
        var res = new List<string>(n);

        // var sb = new StringBuilder();
        for (var i = 1; i <= n; i++)
        {
            // sb.Clear();
            if (i % 15 == 0) res.Add("FizzBuzz");
            else if (i % 3 == 0) res.Add("Fizz");
            else if (i % 5 == 0) res.Add("Buzz");
            
            else res.Add(i.ToString());
        }
        return res;
    }
}
// @lc code=end

