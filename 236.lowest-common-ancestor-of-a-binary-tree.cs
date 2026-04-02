/*
 * @lc app=leetcode id=236 lang=csharp
 *
 * [236] Lowest Common Ancestor of a Binary Tree
 */

// @lc code=start

using Microsoft.VisualBasic;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // if (root is null) return root;
        // var stack = new Stack<TreeNode>();
        // var curr = root;
        // var minH = int.MaxValue;
        // TreeNode res = null;
        // var firstFound = false;
        // while (curr is not null || stack.Count > 0)
        // {
        //     while (curr is not null)
        //     {
        //         stack.Push(curr);
        //         curr = curr.left;
        //     }

        //     curr = stack.Pop();
        //     var curH = stack.Count + 1;
        //     // 
        //     if (firstFound && curH < minH)
        //     {
        //         minH = curH;
        //         res = curr;
        //     }

        //     if (curr.val == p.val || curr.val == q.val)
        //     {
        //         if (!firstFound)
        //         {
        //             firstFound = true;
        //             minH = curH;
        //             res = curr;
        //         }
        //         else
        //         {
        //             return res;
        //         }
        //     }
            
        //     curr = curr.right;
        // }
        // return res;
        if (ReferenceEquals(root, null)) return null;
        if (ReferenceEquals(root, p) || ReferenceEquals(root, q)) return root;
        var l = LowestCommonAncestor(root.left, p, q);
        var r = LowestCommonAncestor(root.right, p, q);
        
        if (l is not null && r is not null) return root;
        if (l is not null) return l;
        return r;
    }
}
// @lc code=end

