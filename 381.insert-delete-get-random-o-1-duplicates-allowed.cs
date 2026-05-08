/*
 * @lc app=leetcode id=381 lang=csharp
 *
 * [381] Insert Delete GetRandom O(1) - Duplicates allowed
 */

// @lc code=start
public class RandomizedCollection
{
    List<int> values = new List<int>();
    Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>>();
    public RandomizedCollection()
    {

    }

    public bool Insert(int val)
    {
        values.Add(val);
        if (dict.TryGetValue(val, out var v))
        {
            v.Add(values.Count - 1);
            return false;
        } else
        {
            dict[val] = new HashSet<int>{values.Count - 1};
            return true;
        }
    }

    public bool Remove(int val)
    {
        if (dict.TryGetValue(val, out var v))
        {
            var lastidx = values.Count - 1;
            var lastel = values[lastidx];

            int remIdx = (val == lastel) ? lastidx : v.First();

            if (remIdx != lastidx)
            {
                values[remIdx] = lastel;
                dict[lastel].Add(remIdx);
                dict[lastel].Remove(lastidx);
                
            }
            values.RemoveAt(lastidx);
            v.Remove(remIdx);
            if (v.Count == 0) dict.Remove(val);
            return true;
        }
        return false;
    }

    public int GetRandom()
    {
        var idx = Random.Shared.Next(0, values.Count);
        return values[idx];
    }
}

/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
// @lc code=end

