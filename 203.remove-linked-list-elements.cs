/*
 * @lc app=leetcode id=203 lang=csharp
 *
 * [203] Remove Linked List Elements
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
    public ListNode RemoveElements(ListNode head, int val) {
        var dummy = new ListNode(0, head);
        var prev = dummy;
        var curr = head;

        while (curr != null)
        {
            if (curr.val == val)
            {
                prev.next = curr.next;
                curr = prev.next;
            } else
                (prev, curr) = (curr, curr.next);
        }
        return dummy.next;
    }
}
// @lc code=end

