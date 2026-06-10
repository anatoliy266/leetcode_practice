/*
 * @lc app=leetcode id=432 lang=csharp
 *
 * [432] All O`one Data Structure
 */

// @lc code=start

public class Node()
{
    public HashSet<string> strings = new HashSet<string>();
    public Node next;
    public Node prev;
    public int count;
}

public class AllOne
{

    private Dictionary<string, Node> dict = new Dictionary<string, Node>();
    Node head = new Node();
    Node tail = new Node();

    public AllOne()
    {
        head.next = tail;
        tail.prev = head;
    }

    public void Inc(string key)
    {
        if (dict.ContainsKey(key))
        {
            var node = dict[key];
            node.strings.Remove(key);
            if (node.next.count == node.count + 1)
            {
                node.next.strings.Add(key);
                dict[key] = node.next;
            }
            else
            {
                var newNode = new Node();
                newNode.count = node.count + 1;
                newNode.strings.Add(key);

                node.next.prev = newNode;
                newNode.next = node.next;
                newNode.prev = node;
                node.next = newNode;

                dict[key] = newNode;
            }
            if (node.strings.Count == 0)
            {
                node.prev.next = node.next;
                node.next.prev = node.prev;
            }
        }
        else
        {
            if (head.next.count == 1)
            {
                head.next.strings.Add(key);
                dict[key] = head.next;
            }
            else
            {
                var newNode = new Node();
                newNode.count = 1;
                newNode.strings.Add(key);


                head.next.prev = newNode;
                newNode.next = head.next;
                newNode.prev = head;
                head.next = newNode;

                dict[key] = newNode;
            }
        }
    }

    public void Dec(string key)
    {
        if (dict.ContainsKey(key))
        {
            var node = dict[key];

            node.strings.Remove(key);
            if (node.count == 1)
            {
                dict.Remove(key);
            }
            else
            {
                if (node.prev.count == node.count - 1)
                {
                    node.prev.strings.Add(key);
                    dict[key] = node.prev;
                }
                else
                {
                    var newNode = new Node();
                    newNode.count = node.count - 1;
                    newNode.strings.Add(key);

                    node.prev.next = newNode;
                    newNode.prev = node.prev;
                    newNode.next = node;
                    node.prev = newNode;

                    dict[key] = newNode;
                }
            }


            if (node.strings.Count == 0)
            {
                node.prev.next = node.next;
                node.next.prev = node.prev;
            }
        }
    }

    public string GetMaxKey()
    {
        return tail.prev.strings.Count == 0 ? "" : tail.prev.strings.First();
    }

    public string GetMinKey()
    {
        return head.next.strings.Count == 0 ? "" : head.next.strings.First();
    }
}

/**
 * Your AllOne object will be instantiated and called as such:
 * AllOne obj = new AllOne();
 * obj.Inc(key);
 * obj.Dec(key);
 * string param_3 = obj.GetMaxKey();
 * string param_4 = obj.GetMinKey();
 */
// @lc code=end

