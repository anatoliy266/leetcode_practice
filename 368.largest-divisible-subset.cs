/*
 * @lc app=leetcode id=368 lang=csharp
 *
 * [368] Largest Divisible Subset
 */

// @lc code=start
public class Solution
{
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        Array.Sort(nums);
        var parent = new int[nums.Length];
        var dp = new int[nums.Length];
        var max = 0;
        var idx = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            dp[i] = 1;
            parent[i] = -1;
            for (var j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] == 0)
                {
                    if (dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        parent[i] = j;
                    }
                }
            }
            if (max < dp[i])
            {
                max = dp[i];
                idx = i;
            }

        }

        var res = new List<int>();

        while (max > 0)
        {
            res.Add(nums[idx]);
            idx = parent[idx];
            max--;
        }
        return res;
    }
}
// @lc code=end

