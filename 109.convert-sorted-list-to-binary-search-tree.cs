/*
 * @lc app=leetcode id=109 lang=csharp
 *
 * [109] Convert Sorted List to Binary Search Tree
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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public TreeNode SortedListToBST(ListNode head)
    {
        var dummy = new TreeNode(0);
        var current = dummy;
        var cnt = 0;
        while (head != null)
        {
            current.right = new TreeNode(head.val);
            current = current.right;
            head = head.next;
            cnt++;
        }
        //идеальное число узлорв для сбалансированного дерева < cnt
        int m = (int)Math.Pow(2, (int)Math.Log2(cnt+1)) - 1;

        Rotate(dummy, cnt-m);

        for (int i = (int)(m/2); i > 0; i /= 2)
        {
            Rotate(dummy, i);
        }
        return dummy.right;
    }

    public void Rotate(TreeNode node, int cnt)
    {
        var prev =  node;
        for (var i = 0; i < cnt; i++)
        {
            var a = prev.right;
            var b = a.right;

            a.right = b.left;
            b.left = a;
            prev.right = b;

            prev = b;
        }
    }
}
// @lc code=end

