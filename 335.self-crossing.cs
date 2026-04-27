/*
 * @lc app=leetcode id=335 lang=csharp
 *
 * [335] Self Crossing
 */

// @lc code=start
public class Solution
{
    public bool IsSelfCrossing(int[] distance)
    {
        for (var i = 0; i < distance.Length; i++)
        {
            if (i  >= 3 && distance[i] >= distance[i - 2] && distance[i - 1] <= distance[i - 3]) return true;
            if (i >= 4 && distance[i-1] == distance[i-3] && distance[i-2] <= (distance[i] + distance[i-4])) return true;
            if (i >= 5 && distance[i-1] + distance[i-5] >= distance[i-3] && distance[i-2] >= distance[i-4] && distance[i-1] <= distance[i-3] && distance[i] + distance[i-4] >= distance[i-2]) return true;
        }
        return false;
    }
}
// @lc code=end

