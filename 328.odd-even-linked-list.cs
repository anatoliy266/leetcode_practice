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
public class Solution
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null) return null;

        var d1 = new ListNode(0, head);
        var d2 = new ListNode(0, head.next);
        var d2Head = d2.next;

        var curr = head;
        var cnt = 0;
        while (curr is not null)
        {
            if (cnt % 2 == 0)
            {
                d1.next = curr;
                d1 = d1.next;
            }
            else
            {
                d2.next = curr;
                d2 = d2.next;
            }
            curr = curr.next;
            cnt++; // ✅ инкрементируем
        }

        d1.next = d2Head;
        d2.next = null;

        return head;
    }
}
// @lc code=end

