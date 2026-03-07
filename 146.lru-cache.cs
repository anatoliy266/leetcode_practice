/*
 * @lc app=leetcode id=146 lang=csharp
 *
 * [146] LRU Cache
 */

// @lc code=start
using System.Data;
using Microsoft.VisualBasic;

public class LRUCache
{
    class Node
    {
        public int Key, Val;
        public Node Prev, Next;
    }
    private int _capacity;
    private Dictionary<int, Node> dict;
    Node last, first;
    // private LinkedList<(int key, int val)> list;

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        dict = new Dictionary<int, Node>(capacity);
        // list = new LinkedList<(int key, int val)>();
        last = new Node();
        first = new Node();
        first.Next = last;
        last.Prev = first;
    }

    public int Get(int key)
    {
        if (!dict.ContainsKey(key)) return -1;
        var node = dict[key];
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
        var temp = first.Next;
        node.Next = temp;
        node.Prev = first;
        first.Next = node;
        temp.Prev = node;
        // if (!dict.ContainsKey(key)) return -1;
        // var node = dict[key];
        // list.Remove(node);
        // list.AddFirst(node);

        return node.Val;
    }

    public void Put(int key, int value)
    {
        if (dict.ContainsKey(key))
        {
            var node = dict[key];
            node.Val = value;
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;

            var temp = first.Next;
            node.Next = temp;
            node.Prev = first;
            first.Next = node;
            temp.Prev = node;
        }
        else
        {
            if (dict.Count >= _capacity)
            {
                var n = last.Prev;
                dict.Remove(n.Key);
                n.Prev.Next = n.Next;
                n.Next.Prev = n.Prev;
            }
            var node = new Node(){ Key = key, Val = value };
            dict[key] = node;
            var temp = first.Next;
            node.Next = temp;
            node.Prev = first;
            first.Next = node;
            temp.Prev = node;

        }

    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

