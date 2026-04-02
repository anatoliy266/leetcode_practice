/*
 * @lc app=leetcode id=234 lang=csharp
 *
 * [234] Palindrome Linked List
 */

// @lc code=start

using System.Runtime.InteropServices.Marshalling;

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
    public bool IsPalindrome(ListNode head) {

        // var list = new  List<int>();
        // var curr = head;
        // while (curr is not null)
        // {
        //     list.Add(curr.val);
        //     curr = curr.next;
        // }
        // var (left, right) = (0, list.Count-1);
        // while (left < right)
        // {
        //     if (list[left] != list[right]) return false; 
        //     left++;
        //     right--;
        // }
        // return list[left] == list[right];

        // var (fast, slow) = (head, head);
        // while (fast != null && fast.next != null)
        // {
        //     fast = fast.next.next;
        //     slow = slow.next;
        // }
        
        // ListNode prev = null;
        // while (slow is not null)
        // {
        //     var next = slow.next;
        //     slow.next = prev;
        //     prev = slow;
        //     slow = next;
        // }
        // while (prev is not null)
        // {
        //     if (prev.val != head.val) return false;
        //     prev = prev.next;
        //     head = head.next;
        // }
        // return true;

        var (forward, backward) = ((long)0,(long)0);
        long pow = 1;
        long d = (long)Math.Pow(10, 9)  + 7;
        while (head is not null)
        {
            forward = (forward * 11 + head.val) % d;
            backward = (head.val * pow + backward) % d;
            pow = pow*11 % d;
            head = head.next;
        }
        return forward == backward;
    }
}
// @lc code=end

