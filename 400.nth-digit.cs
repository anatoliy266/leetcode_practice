/*
 * @lc app=leetcode id=400 lang=csharp
 *
 * [400] Nth Digit
 */

// @lc code=start
using System.ComponentModel.DataAnnotations;

public class Solution
{
    public int FindNthDigit(int n)
    {
        long  start = 1;
        var place = 1;
        long numbers = 9;

        while (n > place * numbers)
        {
            n-= (int)(place * numbers);
            start *= 10;
            numbers *= 10;  
            place++;
        }
        long  d = start + (n-1) / place;
        var  digitFromRight = place - 1 - ((n - 1) % place);
        for (var i = 0; i < digitFromRight; i++)
        {
            d /= 10;
        }
        return (int)d % 10;
    }
}
// @lc code=end

