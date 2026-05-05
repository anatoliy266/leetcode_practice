/*
 * @lc app=leetcode id=374 lang=csharp
 *
 * [374] Guess Number Higher or Lower
 */

// @lc code=start
/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        var (l, r) = (0, n);
        while (l < r)
        {
            var mid = l + (r - l) / 2;
            if (guess(mid) == -1) r = mid;
            else if (guess(mid) == 1) l = mid + 1;
            else return mid;

        }

        return l;
    }
}
// @lc code=end

