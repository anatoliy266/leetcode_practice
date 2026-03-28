/*
 * @lc app=leetcode id=221 lang=csharp
 *
 * [221] Maximal Square
 */

// @lc code=start
public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        // var (m,n) = (matrix.Length, matrix[0].Length);
        // var dp = new int[m,n];
        // var maxSide = 0;

        // for (var i = 0; i < m; i++)
        // {
        //     for (var j = 0; j < n; j++)
        //     {
        //         if (matrix[i][j] == '1')
        //         {
        //             if (i == 0 || j == 0)
        //             {
        //                 dp[i,j] = 1;
        //             }
        //             else {
        //                 dp[i,j] = Math.Min(dp[i-1,j-1], Math.Min(dp[i-1,j], dp[i,j-1])) +1;
        //             }
        //         }
        //         maxSide = Math.Max(maxSide, dp[i,j]);
        //     }
        // }
        // return maxSide*maxSide; 

        var (m, n) = (matrix.Length, matrix[0].Length);
        var dp = new int[n + 1];
        int maxSide = 0, prev = 0;

        for (var i = 1; i <= m; i++)
        {
            for (var j = 1; j <= n; j++)
            {
                int temp = dp[j];
                if (matrix[i-1][j-1] == '1')
                {
                    dp[j] = Math.Min(Math.Min(dp[j-1], dp[j]), prev)+1;
                    maxSide = Math.Max(maxSide, dp[j]);
                } else
                {
                    dp[j] = 0;
                }
                prev = temp;
            }
            prev = 0;
        }
        return maxSide*maxSide;
    }
}
// @lc code=end

