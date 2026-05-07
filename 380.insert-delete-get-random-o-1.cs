/*
 * @lc app=leetcode id=380 lang=csharp
 *
 * [380] Insert Delete GetRandom O(1)
 */

// @lc code=start
public class RandomizedSet
{
    List<int> values = new List<int>();
    Dictionary<int, int> dict = new Dictionary<int, int>();
    public RandomizedSet()
    {

    }

    public bool Insert(int val)
    {
        if (dict.ContainsKey(val))
        {
            return false;
        }
        values.Add(val);
        dict[val] = values.Count - 1;
        return true;
    }

    public bool Remove(int val)
    {
        if (dict.TryGetValue(val, out var v))
        {
            var lastidx = values.Count - 1;
            var lastel = values[lastidx];

            if (v != lastidx)
            {
                values[v] = lastel;
                dict[lastel] = v;
            }



            values.RemoveAt(lastidx);
            dict.Remove(val);
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
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
// @lc code=end

