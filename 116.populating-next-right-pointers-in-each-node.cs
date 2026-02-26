/*
 * @lc app=leetcode id=116 lang=csharp
 *
 * [116] Populating Next Right Pointers in Each Node
 */

// @lc code=start

// Definition for a Node.
using System.Runtime.InteropServices.Marshalling;
using System.Xml;

// public class Node {
//     public int val;
//     public Node left;
//     public Node right;
//     public Node next;

//     public Node() {}

//     public Node(int _val) {
//         val = _val;
//     }

//     public Node(int _val, Node _left, Node _right, Node _next) {
//         val = _val;
//         left = _left;
//         right = _right;
//         next = _next;
//     }
// }


public class Solution {
    public Node Connect(Node root) {
        // if (root == null) return root;
        // var queue = new Queue<Node>();
        // queue.Enqueue(root);

        // while (queue.Count > 0)
        // {
        //     var qL = queue.Count;
        //     Node n = null;
        //     // var n = queue.Dequeue();
        //     // if (n.left != null) queue.Enqueue(n.left);
        //     // if (n.right != null) queue.Enqueue(n.right);
        //     for (var i = 0; i < qL; i++)
        //     {
        //         var nn = queue.Dequeue();
        //         if (n == null) n = nn;
        //         else {
        //             n.next = nn;
        //             n = n.next;
        //         }
                
        //         if (nn.left != null) queue.Enqueue(nn.left);
        //         if (nn.right != null) queue.Enqueue(nn.right);
        //     }
        // }
        // return root;
        Dfs(root);
        return root;

    }

    public void Dfs(Node node)
    {
        if (node == null || node.left == null) return;
        if (node.left != null)
        {
            node.left.next = node.right;
        }
        if (node.next != null)
        {
            if (node.next.left != null) node.right.next = node.next.left;
            else if (node.next.right != null) node.right.next = node.next.right;
        }

        Dfs(node.left);
        Dfs(node.right);
    }
    
}
// @lc code=end

