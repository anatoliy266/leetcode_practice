/*
 * @lc app=leetcode id=206 lang=csharp
 *
 * [206] Reverse Linked List
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
    public ListNode ReverseList(ListNode head) {
        // var dummy = new ListNode(0, head);
        // var prev = dummy;
        // var curr = head;
        // while (curr != null && curr.next != null)
        // {
        //     var next = curr.next;
        //     curr.next = next.next;
        //     next.next = prev.next;
        //     prev.next = next;
            

        // }
        // return dummy.next;

        if (head == null || head.next == null) return head;
        var prev = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return prev;
    }
}
// @lc code=end

