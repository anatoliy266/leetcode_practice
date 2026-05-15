/*
 * @lc app=leetcode id=397 lang=csharp
 *
 * [397] Integer Replacement
 */

// @lc code=start
public class Solution {
    // int minCnt = int.MaxValue;
    public int IntegerReplacement(int n) {
        // Dfs(n, 0);
        // return minCnt;
        // var cnt = 0;
        // var c = (long)n;
        // while (c > 1)
        // {
        //     if (c % 2 == 0) c /=2;
        //     else if (c == 3 || c % 4 == 1) c--;
        //     else c++;
        //     cnt++;
        // }
        // return cnt;
        var c = (long)n;
        var cnt = 0;
        while (c > 1)
        {
            if ((c & 1) == 0) c >>>= 1;
            else if (c == 3 || (c & 3) == 1) c--;
            else c++;
            cnt++;
        }
        return cnt;
    }

    
    // public void Dfs(int n, int cnt)
    // {
    //     if (n == 1)
    //     {
    //         if (minCnt > cnt) minCnt = cnt;
    //         return;
    //     }
    //     if (n % 2 == 0) Dfs(n/2, cnt+1);
    //     else
    //     {
    //         Dfs(n+1, cnt+1);
    //         Dfs(n-1, cnt+1);
    //     }
    // }
}
// @lc code=end

