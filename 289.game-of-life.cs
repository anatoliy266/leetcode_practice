/*
 * @lc app=leetcode id=289 lang=csharp
 *
 * [289] Game of Life
 */

// @lc code=start
public class Solution
{
    public void GameOfLife(int[][] board)
    {
        var (m, n) = (board.Length, board[0].Length);
        var calculations = new int[m * n];
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var alives = GetAliveNeighbours(i, j, board);
                if (board[i][j] == 1)
                {
                    calculations[n * i + j] = (alives == 2 || alives == 3) ? 1 : 0;
                } else
                {
                    calculations[n * i + j] = (alives == 3) ? 1 : 0;
                }
            }
        }

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                board[i][j] = calculations[n * i + j];
            }
        }
    }

    public int GetAliveNeighbours(int i, int j, int[][] board)
    {
        var res = 0;
        for (var m = i - 1; m <= i + 1; m++)
        {
            for (var n = j - 1; n <= j + 1; n++)
            {
                if (m == i && n == j) continue;
                if (m >= 0 && m < board.Length && n >= 0 && n < board[0].Length)
                {
                    if (board[m][n] == 1) res++;
                }
            }
        }
        return res;
    }
}
// @lc code=end

