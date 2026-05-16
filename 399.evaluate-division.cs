/*
 * @lc app=leetcode id=399 lang=csharp
 *
 * [399] Evaluate Division
 */

// @lc code=start
public class Solution
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        var dict = new Dictionary<string, List<(string, double)>>();

        for (var i = 0; i < equations.Count; i++)
        {
            if (dict.TryGetValue(equations[i][0], out var list)) list.Add((equations[i][1], values[i]));
            else dict[equations[i][0]] = new List<(string, double)> { (equations[i][1], values[i]) };

            if (dict.TryGetValue(equations[i][1], out var list1)) list1.Add((equations[i][0], 1 / values[i]));
            else dict[equations[i][1]] = new List<(string, double)> { (equations[i][0], 1/ values[i]) };
        }
        var res = new List<double>();

        for (var i = 0; i < queries.Count; i++)
        {
            var from = queries[i][0];
            var to = queries[i][1];

            if (!dict.TryGetValue(from, out var val)) { res.Add(-1); continue; }
            if (!dict.TryGetValue(to, out var val1)) { res.Add(-1); continue; }
            if (from == to)
            {
                res.Add(1.0);
                continue;
            }

            var queue = new Queue<(string, double)>();
            var visited = new HashSet<string>();

            queue.Enqueue((from, 1.0));
            visited.Add(from);

            var found = false;

            while (queue.Count > 0)
            {
                var (f, v) = queue.Dequeue();
                if (f == to)
                {
                    res.Add(v);
                    found = true;
                    break;
                }

                foreach (var (t, vv) in dict[f])
                {
                    if (visited.Add(t)) queue.Enqueue((t, v * vv));
                }
            }
            if (!found)
            {
                res.Add(-1.0);
            }
        }
        return res.ToArray();
    }
}
// @lc code=end

