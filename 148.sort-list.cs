/*
 * @lc app=leetcode id=148 lang=csharp
 *
 * [148] Sort List
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
    public ListNode SortList(ListNode head)
    {
        var length = 0;
        var c = head;
        while (c != null)
        {
            length++;
            c = c.next;
        }

        var dummy = new ListNode(0, head);
        for (var i = 1; i < length; i *= 2)
        {
            var prev = dummy;
            var curr = dummy.next;

            while (curr != null)
            {
                var left = curr;
                for (var j = 1; j < i && curr.next != null; j++)
                {
                    curr = curr.next;
                }
                var right = curr.next;
                curr.next = null;
                curr = right;
                for (var j = 1; j < i && curr != null && curr.next != null; j++)
                {
                    curr = curr.next;
                }
                ListNode tail = null;
                if (curr != null)
                {
                    tail = curr.next;
                    curr.next = null;
                }



                while (left != null || right != null)
                {
                    if (left != null && (right == null || left.val <= right.val))
                    {
                        prev.next = left;
                        left = left.next;
                    }
                    else
                    {
                        prev.next = right;
                        right = right.next;
                    }
                    prev = prev.next;
                }
                curr = tail;
            }
        }
        return dummy.next;
    }
}
// @lc code=end

