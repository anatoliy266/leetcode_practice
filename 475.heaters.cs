/*
 * @lc app=leetcode id=475 lang=csharp
 *
 * [475] Heaters
 */

// @lc code=start
public class Solution {
    public int FindRadius(int[] houses, int[] heaters) {
        Array.Sort(heaters);
        var maxR = 0;
        foreach (var house in houses)
        {
            var (l,r) = (0, heaters.Length-1);
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (heaters[mid] == house) {
                    l = mid;
                    r = mid;
                    break;
                }
                
                if (house > heaters[mid]) l = mid+1;
                else r = mid-1; 
            }
            var lMin = (r >= 0) ? house - heaters[r] : int.MaxValue;
            var rMin = (l < heaters.Length) ? heaters[l] - house : int.MaxValue;

            var minR = Math.Min(lMin, rMin);
            maxR = Math.Max(maxR, minR);
        }
        return maxR;
    }
}
// @lc code=end

