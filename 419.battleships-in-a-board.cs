/*
 * @lc app=leetcode id=419 lang=csharp
 *
 * [419] Battleships in a Board
 */

// @lc code=start
using System.ComponentModel;
using System.Reflection.Metadata;

public class Solution
{
    public int CountBattleships(char[][] board)
    {
        // if (board.Length == 0) return 0;
        // var (row, col) = (board.Length, board[0].Length);

        // var visited = new bool[row][];
        // for (var i = 0; i < row; i++) visited[i] = new bool[col];

        // var cnt = 0;

        // for (var i = 0; i < row; i++)
        // {
        //     for (var j = 0; j < col; j++)
        //     {
        //         if (!visited[i][j] && board[i][j] == 'X')
        //         {
        //             cnt++;
        //             Bfs(board, i,j, visited);
        //         }
        //     }
        // }
        // return cnt;
        if (board.Length == 0) return 0;
        var cnt = 0;
        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == 'X')
                {
                    if (i > 0 && board[i - 1][j] == 'X') continue;
                    if (j > 0 && board[i][j - 1] == 'X') continue;
                    cnt++;
                }
            }
        }
        return cnt;
    }

    // private void Bfs(char[][] board, int i, int j, bool[][] visited)
    // {
    //     var queue = new Queue<(int, int)>();
    //     queue.Enqueue((i, j));
    //     visited[i][j] = true;
    //     var dirR = new List<int> {1,-1,0,0};
    //     var dirC = new List<int> {0,0,1,-1};
    //     while (queue.Count > 0)
    //     {
    //         var (r, c) = queue.Dequeue();
    //         for (var d = 0; d < 4; d++)
    //         {
                
    //             if (r + dirR[d] < 0 || c + dirC[d] < 0 || r + dirR[d] >= board.Length || c + dirC[d] >= board[0].Length) continue;
    //             var el = board[r + dirR[d]][c + dirC[d]];
    //             if (!visited[r + dirR[d]][c + dirC[d]] && el == 'X')
    //             {
    //                 visited[r + dirR[d]][c + dirC[d]] = true;
    //                 queue.Enqueue((r + dirR[d],c + dirC[d]));
    //             }
    //         }
    //     }
    // }
}
// @lc code=end

