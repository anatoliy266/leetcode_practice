/*
 * @lc app=leetcode id=450 lang=csharp
 *
 * [450] Delete Node in a BST
 */

// @lc code=start

using System.Runtime.InteropServices;

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
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        return Dfs(root, key);
    }

    public TreeNode Dfs(TreeNode node, int key)
    {
        if (node is null) return null;
        if (node.val > key)
        {
            node.left = Dfs(node.left, key);
            return node;
        }
        else if (node.val < key)
        {
            node.right = Dfs(node.right, key);
            return node;
        }
        else
        {
            if (node.left is null && node.right is null) return null;
            else if (node.left is null) return node.right;
            else if (node.right is null) return node.left;
            else
            {
                var curr = node.right;
                while (curr.left is not null)
                {
                    curr = curr.left;
                }
                node.val = curr.val;
                node.right = Dfs(node.right, curr.val);

                return node;
            }
        }
    }
}
// @lc code=end

