/*
 * @lc app=leetcode id=135 lang=csharp
 *
 * [135] Candy
 */

// @lc code=start
public class Solution
{
    public int Candy(int[] ratings)
    {
        // var n = ratings.Length;
        // var candies = new int[n];

        // for (int i = 0; i < n; i++) candies[i] = 1;
        // for (var i = 1; i < n; i++)
        // {
        //     if (ratings[i] > ratings[i-1]) candies[i] = candies[i-1]+1;
        // }
        // for (var i = n-2; i >= 0; i--)
        // {
        //     if (ratings[i] > ratings[i+1]) if (candies[i] < candies[i+1]+1) candies[i] = candies[i+1]+1;
        // }

        // return candies.Sum();

        var (up, down, peak, total) = (0, 0, 0, 1);
        for (var i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                up++;
                peak = up+1;
                total += peak;
                down = 0;
            }
            else if (ratings[i] == ratings[i - 1])
            {
                up = 0;
                peak = 0;
                down = 0;
                total += 1;
            }
            else
            {
                down++;
                up = 0;
                total += down + (down >= peak ? 1 : 0);
            }
            
        }
        return total;
    }
}
// @lc code=end

