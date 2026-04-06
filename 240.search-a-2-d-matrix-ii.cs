/*
 * @lc app=leetcode id=240 lang=csharp
 *
 * [240] Search a 2D Matrix II
 */

// @lc code=start
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var (m,n) = (matrix.Length, matrix[0].Length);
        var i = 0;
        var j = n-1;
        while (i < m && j >= 0)
        {
            if (matrix[i][j] == target) return true;
            if (matrix[i][j] > target) j--;
            else if (matrix[i][j] < target) i++; 
        }
        return false;
    }
}
// @lc code=end

