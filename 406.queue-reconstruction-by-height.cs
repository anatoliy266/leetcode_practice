/*
 * @lc app=leetcode id=406 lang=csharp
 *
 * [406] Queue Reconstruction by Height
 */

// @lc code=start
public class Solution
{
    public int[][] ReconstructQueue(int[][] people)
    {
        var list = new List<int[]>();
        
        Array.Sort(people, (a, b) =>
        {
            if (a[0] != b[0])
            {
                return b[0].CompareTo(a[0]);
            }
            return a[1].CompareTo(b[1]);
        });
        for (var i = 0; i < people.Length; i++)
        {
            list.Insert(people[i][1], people[i]);
        }
        return list.ToArray();
    }
}
// @lc code=end

