/*
 * @lc app=leetcode id=429 lang=csharp
 *
 * [429] N-ary Tree Level Order Traversal
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution
{
    public IList<IList<int>> LevelOrder(Node root)
    {

        var queue = new Queue<Node>();
        var res = new List<IList<int>>();
        if (root is null) return res;
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var qL = queue.Count;
            var lvl = new List<int>(qL);
            for (var i = 0; i < qL; i++)
            {
                var el = queue.Dequeue();
                lvl.Add(el.val);


                var childrens = el.children;
                if (childrens is null) continue;

                
                for (var j = 0; j < childrens.Count; j++)
                {
                    
                    if (childrens[j] is not null)
                    {
                        queue.Enqueue(childrens[j]);
                    }
                }
            }
            res.Add(lvl);
        }
        return res;
    }
}
// @lc code=end

