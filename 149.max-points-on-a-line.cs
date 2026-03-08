/*
 * @lc app=leetcode id=149 lang=csharp
 *
 * [149] Max Points on a Line
 */

// @lc code=start
using System.Drawing;

public class Solution
{
    public int MaxPoints(int[][] points)
    {

        var maxCnt = 0;
        var m = points.Length;
        if (m <= 2) return m;
        for (var i = 0; i < m; i++)
        {
            var dict = new Dictionary<(int, int), int>();
            for (var j = i + 1; j < m; j++)
            {
                var dx = points[i][0] - points[j][0];
                var dy = points[i][1] - points[j][1];
                var d = GCD(dx, dy);
                var (x, y) = (dx/d, dy/d);
                if (x < 0 || (x == 0 && y < 0))
                {
                    x = -x;
                    y = -y;
                }
                var key = (x,y);
                if (dict.ContainsKey(key))
                    dict[key]++;
                else dict[key] = 2;
            }
            var newMax = dict.Values.DefaultIfEmpty(1).Max();
            if (maxCnt < newMax) maxCnt = newMax;
        }
        
        return maxCnt;
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b; // Остаток становится новым b
            a = temp;  // Старое b становится новым a
        }
        return Math.Abs(a); // Возвращаем модуль на случай отрицательных чисел
    }
}
// @lc code=end

