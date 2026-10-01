/*
 * @lc app=leetcode id=460 lang=csharp
 *
 * [460] LFU Cache
 */

// @lc code=start
public class CacheItem
{
    public int Key { get; set; }
    public int Value { get; set; }
    public int Frequency { get; set; }

    public CacheItem(int key, int value)
    {
        Key = key;
        Value = value;
        Frequency = 1;
    }
}
public class LFUCache
{
    private Dictionary<int, LinkedListNode<CacheItem>> entToFreq = new Dictionary<int, LinkedListNode<CacheItem>>();
    private Dictionary<int, LinkedList<CacheItem>> freqToEnt = new Dictionary<int, LinkedList<CacheItem>>();
    private int cap = 0;
    int min_freq = 1;

    public LFUCache(int capacity)
    {
        cap = capacity;
    }

    public int Get(int key)
    {
        if (!entToFreq.TryGetValue(key, out var node)) return -1;
        freqToEnt[node.Value.Frequency].Remove(node);
        if (node.Value.Frequency == min_freq && freqToEnt[node.Value.Frequency].Count == 0) min_freq++;
        node.Value.Frequency++;
        if (!freqToEnt.TryGetValue(node.Value.Frequency, out var list))
        {
            list = new LinkedList<CacheItem>();
            freqToEnt[node.Value.Frequency] = list;
        }
        list.AddLast(node);
        return node.Value.Value;
    }

    public void Put(int key, int value)
    {
        if (cap <= 0) return;
        if (entToFreq.TryGetValue(key, out var existingNode))
        {
            existingNode.Value.Value = value;
            
            freqToEnt[existingNode.Value.Frequency].Remove(existingNode);
            if (existingNode.Value.Frequency == min_freq && freqToEnt[existingNode.Value.Frequency].Count == 0) min_freq++;
            existingNode.Value.Frequency++;
            
            if (!freqToEnt.TryGetValue(existingNode.Value.Frequency, out var list))
            {
                list = new LinkedList<CacheItem>();
                freqToEnt[existingNode.Value.Frequency] = list;
            }

            list.AddLast(existingNode);
            return;
        }

        if (entToFreq.Count == cap)
        {
            var lst = freqToEnt[min_freq];
            entToFreq.Remove(lst.First.Value.Key);
            lst.RemoveFirst();
        }
        min_freq = 1;
        var item = new CacheItem(key, value);
        if (!freqToEnt.TryGetValue(1, out var newList))
        {
            newList = new LinkedList<CacheItem>();
            freqToEnt[1] = newList;
        }
        var newNode = newList.AddLast(item);

        entToFreq.Add(key, newNode);
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

