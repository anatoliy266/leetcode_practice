/*
 * @lc app=leetcode id=279 lang=csharp
 *
 * [279] Perfect Squares
 */

// @lc code=start
public class Solution {
    public int NumSquares(int n) {
        // var dp = new int[n+1,n+1];
        // dp[0,0] = n;
        
        // for (var i = 1; i <= n; i++)
        // {
        //     int minFromPrev = dp[i - 1, 0];
        //     int currentStepMin = int.MaxValue;

        //     for (var j = 1; j * j <= minFromPrev; j++) 
        //     {
        //         if (IsSquare(j * j)) // твоя проверка
        //         {
        //             int remainder = minFromPrev - (j * j);
                    
        //             if (remainder == 0) return i; // Дошли до нуля — i это ответ

        //             // Записываем остаток в строку
        //             dp[i, j] = remainder;
                    
        //             // Обновляем минимальный остаток для текущей строки
        //             if (remainder < currentStepMin) {
        //                 currentStepMin = remainder;
        //             }
        //         }
        //     }
        //     dp[i, 0] = currentStepMin;
        // }
        // return n;

        var dp = new int[n+1];
        for (var i = 1; i <= n; i++)
        {
            dp[i] = i;
            for (var j = 1; j * j <=i; j++)
            {
                dp[i] = Math.Min(dp[i], 1+dp[i-j*j]);
            }
        }
        return dp[n];
    }

    // public bool IsSquare(int num)
    // {
    //     if (num < 0) return false;
    //     int root = (int)Math.Round(Math.Sqrt(num));
    //     return root * root == num;
    // }
}
// @lc code=end

