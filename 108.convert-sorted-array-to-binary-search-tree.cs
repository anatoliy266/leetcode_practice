/*
 * @lc app=leetcode id=108 lang=csharp
 *
 * [108] Convert Sorted Array to Binary Search Tree
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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return Dfs(nums, 0, nums.Length-1);
    }

    public TreeNode Dfs(int[] nums, int left, int right)
    {
        if (left > right) return null;

        var mid = left + (int)(right - left) / 2;
        var res = new TreeNode(nums[mid]);
        res.left = Dfs(nums, left, mid - 1);
        res.right = Dfs(nums, mid + 1, right);
        return res;
    }
}
// @lc code=end

