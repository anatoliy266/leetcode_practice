/*
 * @lc app=leetcode id=382 lang=csharp
 *
 * [382] Linked List Random Node
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
    ListNode _head;
    public Solution(ListNode head) {
        _head = head;
    }
    
    public int GetRandom() {
        // int steps = Random.Shared.Next(100);
        // var curr = _head;
        // while (steps > 0)
        // {
        //     steps--;
        //     var step = Random.Shared.Next(100);
            
        //     while (step > 0)
        //     {
        //         step--;
        //         curr = curr.next;
        //         if (curr == null) curr = _head;
        //     }
            
        // }
        // return curr.val;
        var scope = 1;
        int val = _head.val;
        var curr = _head;
        while (curr != null)
        {
            if (Random.Shared.Next(scope) == 0)
            {
                val = curr.val;
            }
            scope++;
            curr = curr.next;
        }
        return val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */
// @lc code=end

