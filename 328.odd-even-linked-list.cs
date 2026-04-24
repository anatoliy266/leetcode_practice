/*
 * @lc app=leetcode id=328 lang=csharp
 *
 * [328] Odd Even Linked List
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
    public ListNode OddEvenList(ListNode head) {
        if (head?.next == null) return head;
        var d1 = head;
        var d2 = head.next;
        var d2Head = d2;

        while (d2 is not null && d2.next is not null)
        {
            d1.next = d2.next;
            d1 = d1.next;

            d2.next = d1.next;
            d2 = d2.next;
        }

        d1.next = d2Head;
        
        return head;
    }
}
// @lc code=end

