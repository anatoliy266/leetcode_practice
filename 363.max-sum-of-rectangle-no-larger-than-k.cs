/*
 * @lc app=leetcode id=363 lang=csharp
 *
 * [363] Max Sum of Rectangle No Larger Than K
 */

// @lc code=start
public class Solution
{
    public int MaxSumSubmatrix(int[][] matrix, int k)
    {
        var closest = int.MinValue;
        for (var i = 0; i < matrix[0].Length; i++)
        {
            for (var j = i; j < matrix[0].Length; j++)
            {
                var prefsums = new int[matrix.Length];
                var sum = 0;
                for (var c = 0; c < matrix.Length; c++)
                {
                    
                    var (l, r) = (i, j);
                    while (l < r)
                    {
                        sum += matrix[c][l] + matrix[c][r];
                        l++;
                        r--;
                    }
                    if (l == r) sum += matrix[c][l];
                    prefsums[c] = sum;
                }

                var hist = new List<int>{0};
                
                

                for (var c = 0; c < prefsums.Length; c++)
                {
                    var current = prefsums[c];
                    var target = current - k;

                    var (l,r) = (0, hist.Count);
                    while (l < r)
                    {
                        var mid = l + (r-l)/2;
                        if (hist[mid] >= target) r = mid;
                        else l = mid+1;
                    }
                    if (l < hist.Count)
                    {
                        var s = current - hist[l];
                        if (closest < s) closest = s;
                    }
                    var (insL, insR) = (0,hist.Count);
                    while (insL < insR)
                    {
                        int mid = insL + (insR - insL) / 2;
                        if (hist[mid] >= current) insR = mid;
                        else insL = mid + 1;
                    }
                    hist.Insert(insL, current);
                }

            }
        }
        return closest;

    }
}
// @lc code=end

