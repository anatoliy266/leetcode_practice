/*
 * @lc app=leetcode id=92 lang=csharp
 *
 * [92] Reverse Linked List II
 */

// @lc code=start

// Definition for singly-linked list.
// using Microsoft.VisualBasic;

// public class ListNode {
//      public int val;
//      public ListNode next;
//      public ListNode(int val=0, ListNode next=null) {
//          this.val = val;
//          this.next = next;
//      }
//  }
 
public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        var cnt = 1;
        var dummy = new ListNode(0, head);
        var currentNode = dummy;
        while (cnt < left)
        {
            currentNode = currentNode.next;
            cnt++;
        }
        var prevNode = currentNode;
        var leftNode = prevNode.next;
        var i = 0;
        while(i < right - left)
        {
            var movingNode = leftNode.next;
            leftNode.next = movingNode.next;
            movingNode.next = prevNode.next;
            prevNode.next = movingNode;

            i++;
        }
        return dummy.next;
    }
}
// @lc code=end

