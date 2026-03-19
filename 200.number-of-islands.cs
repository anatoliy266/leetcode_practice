/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 */

// @lc code=start
public class Solution {
    public int NumIslands(char[][] grid) {
        if (grid.Length == 0) return 0;
        var (m,n) = (grid.Length,grid[0].Length);
        // var seen = new bool[m][];
        // for (var i =0; i < m; i++)
        // {
        //     seen[i] = new bool[n];
        // }
        var cnt = 0;
        for (var i = 0; i < m; i++)
        {
            for (var j =0; j < n; j++)
            {
                if (grid[i][j] == '1')//&& !seen[i][j]
                {
                    cnt++;
                    // Isle(grid, seen, i, j);
                     Isle(grid, i, j);
                }
            }
        } 
        return cnt;
    }

    // public void Isle(char[][] grid, bool[][] seen, int i, int j)
    public void Isle(char[][] grid, int i, int j)
    {
        // seen[i][j] = true;
        grid[i][j] = '0';
        // if (i > 0 &&!seen[i-1][j] && grid[i-1][j] == '1') Isle(grid, seen, i-1, j);
        // if (i < seen.Length-1 && !seen[i+1][j] && grid[i+1][j] == '1') Isle(grid, seen, i+1, j);

        // if (j > 0 &&!seen[i][j-1] && grid[i][j-1] == '1') Isle(grid, seen, i, j-1);
        // if (j < seen[0].Length-1 && !seen[i][j+1] && grid[i][j+1] == '1') Isle(grid, seen, i, j+1);

        if (i > 0 && grid[i-1][j] == '1') Isle(grid, i-1, j);
        if (i < grid.Length-1 && grid[i+1][j] == '1') Isle(grid, i+1, j);

        if (j > 0 && grid[i][j-1] == '1') Isle(grid, i, j-1);
        if (j < grid[0].Length-1 && grid[i][j+1] == '1') Isle(grid, i, j+1);
    }
}
// @lc code=end

