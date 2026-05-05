/*
 * @lc app=leetcode id=375 lang=csharp
 *
 * [375] Guess Number Higher or Lower II
 */

// @lc code=start
public class Solution
{
    int[,] memo;
    public int GetMoneyAmount(int n)
    {
        memo = new int[n+1,n+1];
        return Dfs(1, n);
    }

    public int Dfs(int l, int r)
    {
        if (l >= r) return 0;
        if (memo[l,r] != 0) return memo[l,r];
        var bestWorst = int.MaxValue;
        for (var i = l; i <= r; i++)
        {
            var worst = i + Math.Max(Dfs(l, i-1), Dfs(i+1, r));
            
            if (bestWorst > worst) bestWorst = worst;
        }
        memo[l,r] = bestWorst;
        return bestWorst;
    }
}
// @lc code=end

