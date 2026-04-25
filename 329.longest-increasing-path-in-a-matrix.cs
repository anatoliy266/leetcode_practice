/*
 * @lc app=leetcode id=329 lang=csharp
 *
 * [329] Longest Increasing Path in a Matrix
 */

// @lc code=start
public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        var max = int.MinValue;
        var memo = new int[matrix.Length * matrix[0].Length];
        for (var i = 0; i < memo.Length; i++) memo[i] = int.MinValue;
        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[0].Length; j++)
            {
                var localmax = Dfs(matrix, i,j, memo);
                if (max < localmax) max = localmax;
            }
        }
        return max;
    }

    private int Dfs(int[][] matrix, int i, int j, int[] memo)
    {
        var flatIdx = i * matrix[0].Length + j;
        if (memo[flatIdx] > 0) return memo[flatIdx];
        var lMAx = 0;
        if (i > 0 && matrix[i][j] < matrix[i-1][j]) lMAx = Math.Max(lMAx, Dfs(matrix, i-1, j, memo));
        if (i < matrix.Length-1 && matrix[i][j] < matrix[i+1][j]) lMAx = Math.Max(lMAx, Dfs(matrix, i+1, j, memo));
        if (j > 0 && matrix[i][j] < matrix[i][j-1]) lMAx = Math.Max(lMAx, Dfs(matrix, i, j-1, memo));
        if (j < matrix[0].Length-1 && matrix[i][j] < matrix[i][j+1]) lMAx = Math.Max(lMAx, Dfs(matrix, i, j+1, memo));

        memo[flatIdx] = lMAx+1;
        return lMAx+1;
    }
}
// @lc code=end

