/*
 * @lc app=leetcode id=138 lang=csharp
 *
 * [138] Copy List with Random Pointer
 */

// @lc code=start
/*
// Definition for a Node.

*/
// public class Node {
//     public int val;
//     public Node next;
//     public Node random;
    
//     public Node(int _val) {
//         val = _val;
//         next = null;
//         random = null;
//     }
// }

public class Solution {
    // Dictionary<Node, Node> memo = new Dictionary<Node, Node>();
    public Node CopyRandomList(Node head) {
        // if (head == null) return null;
        // if (memo.ContainsKey(head)) return memo[head];
        
        // var node = new Node(head.val);
        // memo[head] = node;
        // node.random = CopyRandomList(head.random);
        // node.next = CopyRandomList(head.next);
        // return node;

        // if (head == null) return null;

        // var memo = new Dictionary<Node, Node>();
        // var stack = new Stack<Node>();

        // stack.Push(head);
        // memo[head] = new Node(head.val);

        // while (stack.Count > 0)
        // {
        //     var node = stack.Pop();
        //     var copy = memo[node];

        //     if (node.next != null)
        //     {
        //         if (!memo.ContainsKey(node.next))
        //         {
        //             memo[node.next] = new Node(node.next.val);
        //             stack.Push(node.next);
        //         }
        //         copy.next = memo[node.next];
        //     }

        //     if (node.random != null)
        //     {
        //         if (!memo.ContainsKey(node.random))
        //         {
        //             memo[node.random] = new Node(node.random.val);
        //             stack.Push(node.random);
        //         }
        //         copy.random = memo[node.random];
        //     }
        // }
        // return memo[head];

        if (head == null) return null;
        var dummy = new Node(0);

        var current = head;

        while (current != null)
        {
            var node = new Node(current.val);
            (current.next, node.next, current) = (node, current.next,current.next);
        }

        current = head;
        while (current != null)
        {
            if (current.random != null)
            {
                current.next.random = current.random.next;
            }
            current = current.next.next;
        }

        current = head;
        var d = dummy;
        while(current != null)
        {
            (d.next, current.next, current, d) = (current.next, current.next.next, current.next.next, current.next);
        }

        return dummy.next;
    }
}
// @lc code=end

