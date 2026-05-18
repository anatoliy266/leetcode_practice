/*
 * @lc app=leetcode id=401 lang=csharp
 *
 * [401] Binary Watch
 */

// @lc code=start
public class Solution {
    public IList<string> ReadBinaryWatch(int turnedOn) {
        var h = new int[]{1,2,4,8};
        var m = new int[]{1,2,4,8,16,32};
        var res = new List<string>();
        BackTrack(h,m,0,0,0,0,0, turnedOn,  res);
        return res;
    }

    public void BackTrack(int[] h, int[] m, int startH, int startM, int currH, int currM, int currOn, int turnedOn, List<string> res)
    {
        if (currH > 11) return;
        if (currM > 59) return;
        if (currOn == turnedOn)
        {
            var dt = $"{currH}:{currM:D2}";
            res.Add(dt);
            return;
        }

        for (var i = startH; i < h.Length; i++)
        {
            BackTrack(h,m, i+1, startM, currH + h[i], currM, currOn + 1, turnedOn, res);
        }

        for (var i = startM; i < m.Length; i++)
        {
            BackTrack(h,m,h.Length, i+1,currH, currM + m[i], currOn +1, turnedOn, res);
        }
    }
}
// @lc code=end

