/*
 * @lc app=leetcode id=114 lang=csharp
 *
 * [114] Flatten Binary Tree to Linked List
 */

// @lc code=start
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
    public TreeNode last = null;
    public void Flatten(TreeNode root)
    {
        if (root == null) return;
        Flatten(root.right);
        Flatten(root.left);

        root.right = last;
        root.left = null;
        last = root;




        // if (root == null) return;
        // var stack = new Stack<TreeNode>();
        // var dummy = new TreeNode(0);
        // var originalRoot = root;
        // var tempRoot = root;
        // var result = dummy;
        // while (stack.Count > 0 || tempRoot != null)
        // {
        //     while (tempRoot != null)
        //     {
        //         stack.Push(tempRoot);
        //         result.right = new TreeNode(tempRoot.val);
        //         result = result.right;
        //         tempRoot = tempRoot.left;
        //     }
        //     tempRoot = stack.Pop();
        //     tempRoot = tempRoot.right;
        // }
        // originalRoot.left = null;
        // originalRoot.right = dummy.right.right;
    }
}
// @lc code=end

