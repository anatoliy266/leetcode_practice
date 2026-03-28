/*
 * @lc app=leetcode id=216 lang=csharp
 *
 * [216] Combination Sum III
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var result = new List<IList<int>>();
        Backtrack(0, k, n, new List<int>(), result);
        return result;
    }

    private void Backtrack(int idx, int k, int n, List<int> seq, List<IList<int>> res)
    {
        if (seq.Count == k)
        {
            if (n == 0) res.Add(new List<int>(seq));
            return;
        }
        if (k < 0 || n < 0) return;

        for (var i = idx+1; i <= 9; i++)
        {
            if (i > n) break;
            seq.Add(i);
            Backtrack(i, k, n-i, seq, res);
            seq.RemoveAt(seq.Count -1);
        }
    }
}
// @lc code=end

