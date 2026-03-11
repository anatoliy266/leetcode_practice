
/*
 * @lc app=leetcode id=165 lang=csharp
 *
 * [165] Compare Version Numbers
 */

// @lc code=start
public class Solution {
    public int CompareVersion(string version1, string version2) {
        var v1List = version1.Split(".");
        var v2List = version2.Split(".");

        // if (v1List.Length < v2List.Length)
        // {
        //     (v1List, v2List) = (v2List, v1List);
        // }
        var n = Math.Max(v1List.Length, v2List.Length);
        for (var i = 0; i < n; i++)
        {
            var v1 = i < v1List.Length ? int.Parse(v1List[i]) : 0;
            var v2 = i < v2List.Length ? int.Parse(v2List[i]) : 0;

            if (v1 > v2) return 1;
            else if (v1 < v2) return -1;
            else continue;
            
        }
        return 0;
    }
}

// @lc code=end

