/*
 * @lc app=leetcode id=304 lang=csharp
 *
 * [304] Range Sum Query 2D - Immutable
 */

// @lc code=start
public class NumMatrix {
    private int[][] sums;
    public NumMatrix(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        sums = new int[rows+1][];
        for (var i = 0; i <= rows; i++) sums[i] = new int[cols+1];
        for (var i = 1; i <= rows; i++)
        {
            for (var j =1; j <= cols; j++)
            {
                sums[i][j] = matrix[i-1][j-1] + sums[i][j-1] + sums[i-1][j] - sums[i-1][j-1];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        return sums[row2+1][col2+1] - sums[row2+1][col1] - sums[row1][col2+1] + sums[row1][col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
// @lc code=end

