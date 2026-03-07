/*
 * @lc app=leetcode id=147 lang=csharp
 *
 * [147] Insertion Sort List
 */

// @lc code=start

using System.Runtime.Serialization.Formatters;
using Microsoft.VisualBasic;

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
    public ListNode InsertionSortList(ListNode head)
    {
        var dummy = new ListNode(int.MinValue, head);

        
        var prevSlow = head;
        var slow = prevSlow.next;


        while (slow != null)
        {
            if (slow.val >= prevSlow.val)
            {
                prevSlow = slow;
                slow = slow.next;
                continue;
            }
            var fast = dummy.next;
            var prevFast = dummy;
            while (fast != slow)
            {
                if (slow.val < fast.val)
                {
                    prevSlow.next = slow.next;
                    prevFast.next = slow;
                    slow.next = fast;
                    break;
                }
                prevFast = fast;
                fast = fast.next;

            }
            slow = prevSlow.next;
        }
        return dummy.next;
    }
}
// @lc code=end

