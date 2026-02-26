/*
 * @lc app=leetcode id=117 lang=csharp
 *
 * [117] Populating Next Right Pointers in Each Node II
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution
{
    public Node Connect(Node root)
    {
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
        var parent = root;
        while (parent != null)
        {
            var dummy = new Node();
            var tail = dummy;
            while (parent != null)
            {
                if (parent.left != null) { tail.next = parent.left; tail = tail.next; }
                if (parent.right != null) { tail.next = parent.right; tail = tail.next; }

                parent = parent.next;
            }
            parent = dummy.next;
        }
        return root;
    }

}
// @lc code=end

