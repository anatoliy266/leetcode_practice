/*
 * @lc app=leetcode id=143 lang=csharp
 *
 * [143] Reorder List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public void ReorderList(ListNode head) {
        var stack =new Stack<ListNode>();
        var curr = head;
        while (curr != null)
        {
            stack.Push(curr);
            curr = curr.next;
        }

        curr  = head;
        var sq = stack.Count;
        for (var i = 0; i < (sq-1) / 2; i++)
        {
            var nextNode = curr.next;
            var el = stack.Pop();
            (curr.next, el.next) = (el, nextNode);
            curr = nextNode;
        }
        stack.Pop().next = null;
    }
}
// @lc code=end

