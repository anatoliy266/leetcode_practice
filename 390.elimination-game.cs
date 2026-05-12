/*
 * @lc app=leetcode id=390 lang=csharp
 *
 * [390] Elimination Game
 */

// @lc code=start
using System.Dynamic;

public class Solution {
    public int LastRemaining(int n) {
        var i = 1;
        var step = 1;
        var dir = 1;
        while (n > 1)
        {
            if (dir == 1) i+= step;
            else if (dir < 0 && n % 2 != 0) i+=step;
            dir = -dir;
            step *= 2;
            n /= 2;
        }
        return i;
    }
}
// @lc code=end

// После каждого прохода (неважно, в какую сторону):
// Количество элементов сокращается вдвое: \(remaining = \lfloor remaining / 2 \rfloor\).
// Размер шага удваивается: \(step = step \times 2\).
// Направление меняется на противоположное.
// Процесс повторяется, пока не останется одно число (\(remaining = 1\)).