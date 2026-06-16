/*
 * @lc app=leetcode id=440 lang=csharp
 *
 * [440] K-th Smallest in Lexicographical Order
 */

// @lc code=start
using Microsoft.VisualBasic;

public class Solution {
    int result = 0;
    public int FindKthNumber(int n, int k) {
        var i = 1;
        k--;
        while (k > 0)
        {
            
            var steps = CountSteps(i, n);
            if (steps > k)
            {
                i *= 10;
                k--;
            } else
            {
                i++;
                k -= steps;
            }
        }

        return i;
        // result = 0; 
        // for (int i = 1; i <= 9; i++) {
        //     if (k > 0) {
        //         Dfs(i, n, ref k);
        //     }
        // }

        // return result;
    }

    public int CountSteps(int curr, int n)
    {
        long steps = 0;
        long first = curr;
        long last = curr;

        while (first <= n) {
            steps += Math.Min(n, last) - first + 1;
            first *= 10;
            last = last * 10 + 9;
        }

        return (int)steps;
    }

    // public void Dfs(long curr, long n, ref int k) {
    //     if (curr > n) return;

    //     k--;

    //     if (k == 0) {
    //         result = (int)curr;
    //         return;
    //     }

    //     for (int i = 0; i <= 9; i++) {
    //         long nextNum = curr * 10 + i;
    //         if (nextNum > n) break;
    //         if (k > 0) {
    //             Dfs(nextNum, n, ref k);
    //         }
    //     }
    // }
}
// @lc code=end

