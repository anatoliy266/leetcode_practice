/*
 * @lc app=leetcode id=378 lang=csharp
 *
 * [378] Kth Smallest Element in a Sorted Matrix
 */

// @lc code=start
public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        var (l, r) = (matrix[0][0], matrix[matrix.Length - 1][matrix[0].Length - 1]);
        while (l < r)
        {
            var mid = l + (r - l) / 2;
            var (i, j) = (matrix.Length - 1, 0);
            var cnt = 0;
            while (i >= 0 && j < matrix[0].Length)
            {
                if (matrix[i][j] <= mid)
                {
                    cnt += (i + 1);
                    j++;  
                }
                else
                {
                    i--; 
                }
            }

            if (cnt >= k) r = mid;
            else l = mid + 1;
        }
        return l;
    }
}
// @lc code=end

