/*
 * @lc app=leetcode id=430 lang=csharp
 *
 * [430] Flatten a Multilevel Doubly Linked List
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/


public class Solution {
    public Node Flatten(Node head) {
        if (head is null) return null;
        var stack = new Stack<Node>();
        Dfs(head, stack);


        var last = stack.Pop();
        while (stack.Count > 0)
        {
            var el = stack.Pop();
            el.child = null;
            last.prev = el;
            el.next = last;
            last = last.prev;
        }

        return last;
    }

    public void Dfs(Node head, Stack<Node> stack)
    {
        var curr = head;
        while (curr is not null)
        {
            stack.Push(curr);
            if (curr.child is not null)
            {
                Dfs(curr.child, stack);
            }
            curr = curr.next;
        }
    }

    
}
// @lc code=end

