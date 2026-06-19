/*
 * @lc app=leetcode id=445 lang=csharp
 *
 * [445] Add Two Numbers II
 */

// @lc code=start

using System.Data.Common;
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        // long d1 = 0;
        // while (l1 is not null)
        // {
        //     d1 = d1 * 10 + l1.val;
        //     l1 = l1.next;
        // }

        // long d2 = 0;
        // while (l2 is not null)
        // {
        //     d2 = d2 * 10 + l2.val;
        //     l2 = l2.next;
        // }

        // var sum = d1 + d2;

        // if (sum == 0) return new ListNode(0);

        // var dummy = new ListNode();

        // var current = dummy;
        // while (sum != 0)
        // {
        //     var val = sum % 10;

        //     var next = new ListNode((int)val);

        //     if (current.next is null) current.next = next;
        //     else
        //     {
        //         next.next = current.next;
        //         current.next = next;
        //     }

        //     sum /= 10;
        // }

        // return dummy.next;

        var stack1 = new Stack<int>();
        while (l1 is not null)
        {
            stack1.Push(l1.val);
            l1 = l1.next;
        }

        var stack2 = new Stack<int>();
        while (l2 is not null)
        {
            stack2.Push(l2.val);
            l2 = l2.next;
        }


        ListNode head = null;
        var add = 0;

        while (stack1.Count > 0 || stack2.Count > 0 || add > 0)
        {
            var d1 = stack1.Count == 0 ? 0 : stack1.Pop();
            var d2 = stack2.Count == 0 ? 0 : stack2.Pop();

            var sum = d1 + d2 + add;

            add = sum / 10;
            sum %= 10;

            var next = new ListNode(sum, head);
            head = next;
        }
        return head;
    }
}
// @lc code=end

