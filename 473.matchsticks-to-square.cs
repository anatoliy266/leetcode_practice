/*
 * @lc app=leetcode id=473 lang=csharp
 *
 * [473] Matchsticks to Square
 */

// @lc code=start
public class Solution
{
    public bool Makesquare(int[] matchsticks)
    {
        var (a, b, c, d) = (0, 0, 0, 0);
        Array.Sort(matchsticks, (a,b) => b.CompareTo(a));
        if (matchsticks.Sum() % 4 != 0) return false;
        var l = matchsticks.Sum() / 4;

        return DFS(matchsticks, 0, l, a, b, c, d);
    }

    public bool DFS(int[] matchsticks, int i, int l, int a, int b, int c, int d)
    {
        if (i == matchsticks.Length) return true;
        var stick = matchsticks[i];
        if (a + stick <= l)
        {
            a = a + stick; 
            if (DFS(matchsticks, i+1, l, a,b,c,d)) return true;
            a = a - stick; 
        }
        if (b != a && b + stick <= l)
        {
            b = b + stick; 
            if (DFS(matchsticks, i+1, l, a,b,c,d)) return true;
            b = b - stick; 
        }
        if (c != b && c != a && c + stick <= l)
        {
            c = c + stick; 
            if (DFS(matchsticks, i+1, l, a,b,c,d)) return true;
            c = c - stick; 
        }
        if (d != c && d != b && d != a && d + stick <= l)
        {
            d = d + stick; 
            if (DFS(matchsticks, i+1, l, a,b,c,d)) return true;
            d = d - stick; 
        } 
        return false;
    }
}
// @lc code=end

