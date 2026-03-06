/*
 * @lc app=leetcode id=142 lang=csharp
 *
 * [142] Linked List Cycle II
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if (head == null || head.next == null) return null; 
        var (fast, slow) = (head, head);
        
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                var start = head;
                while (true)
                {
                    if (start == slow) return slow;
                    start = start.next;
                    slow = slow.next;
                }
            }
        }
        return null;
    }
}
// @lc code=end

