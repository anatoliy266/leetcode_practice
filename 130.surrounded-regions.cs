/*
 * @lc app=leetcode id=130 lang=csharp
 *
 * [130] Surrounded Regions
 */

// @lc code=start
public class Solution
{
    public void Solve(char[][] board)
    {

        var (m, n) = (board.Length, board[0].Length);
        var visited = new int[m][];
        for (var i = 0; i < m; i++)
        {
            visited[i] = new int[n];
        }

        for (var i = 0; i < m; i++)
        {
            Bfs(board, i, 0, visited);
            Bfs(board, i, n - 1, visited);
        }

        for (var j = 0; j < n; j++)
        {
            Bfs(board, 0, j, visited);
            Bfs(board, m - 1, j, visited);
        }

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (board[i][j] == 'O' && visited[i][j] != 1) board[i][j] = 'X';
            }
        }

        // for (var i = 0; i < m; i++)
        // {
        //     for (var j = 0; j < n; j++)
        //     {
        //         if (board[i][j] == 'O' && visited[i][j] != 1)
        //         {
        //             var isBorder = false;
        //             Bfs(board, i, j, visited, ref isBorder);
        //             if (!isBorder)
        //             {
        //                 board[i][j] = 'X';
        //             }
        //         }
        //     }
        // }
    }

    public void Bfs(char[][] board, int i, int j, int[][] visited)
    {
        if (board[i][j] == 'X' || visited[i][j] == 1) return;
        visited[i][j] = 1;
        if (i > 0) Bfs(board, i - 1, j, visited);
        if (i < board.Length - 1) Bfs(board, i + 1, j, visited);
        if (j > 0) Bfs(board, i, j - 1, visited);
        if (j < board[0].Length - 1) Bfs(board, i, j + 1, visited);
    }
}
// @lc code=end

