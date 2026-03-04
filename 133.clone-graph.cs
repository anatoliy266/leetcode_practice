/*
 * @lc app=leetcode id=133 lang=csharp
 *
 * [133] Clone Graph
 */

// @lc code=start
/*
// Definition for a Node.

*/



using System.Xml;


// public class Node {
//     public int val;
//     public IList<Node> neighbors;

//     public Node() {
//         val = 0;
//         neighbors = new List<Node>();
//     }

//     public Node(int _val) {
//         val = _val;
//         neighbors = new List<Node>();
//     }

//     public Node(int _val, List<Node> _neighbors) {
//         val = _val;
//         neighbors = _neighbors;
//     }
// }
public class Solution
{
    public Node CloneGraph(Node node)
    {
        if (node == null) return null;
        var visited = new Dictionary<Node, Node>();
        //var dummy = new Node(0, new List<Node>(){Dfs()});
        return Dfs(node, visited);
    }

    public Node Dfs(Node node, Dictionary<Node, Node> visited)
    {
        if (visited.ContainsKey(node)) {
            return visited[node];
        }
        
        var n = new Node(node.val);
        visited.Add(node, n);
        for (var i = 0; i < node.neighbors.Count; i++)
        {
            n.neighbors.Add(Dfs(node.neighbors[i], visited));
        }
        return n;
    }
}
// @lc code=end

