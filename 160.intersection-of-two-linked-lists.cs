/*
 * @lc app=leetcode id=160 lang=csharp
 *
 * [160] Intersection of Two Linked Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        // ListNode intersectNode = null;
        // var currA = headA;
        // var currB = headB;
        // while (currA.next != null && currA.next != intersectNode)
        // {
        //     currA = currA.next;
        // }
        // intersectNode = currA;

        // while (currB != null && currB != intersectNode)
        // {
        //     currB = currB.next;
        // }


        // if (currB == null) return null;
        var (a,b) = (headA, headB);
        while (a != b)
        {
            a = a == null ? headB : a.next;
            b = b == null ? headA : b.next;
        }
        return a;
    }
}
// @lc code=end

