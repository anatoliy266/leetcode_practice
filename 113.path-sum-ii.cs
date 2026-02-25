/*
 * @lc app=leetcode id=113 lang=csharp
 *
 * [113] Path Sum II
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
    public List<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        if (root == null) return result;
        Dfs(root, targetSum, new List<int>());
        return result;
    }

    public void Dfs(TreeNode root, int targetSum, List<int> list)
    {
        if (root == null) return;
        list.Add(root.val);
        if (root.left == null && root.right == null && targetSum == root.val)
        {
            result.Add(new List<int>(list));
        }
        else
        {
            Dfs(root.left, targetSum - root.val, list);
            Dfs(root.right, targetSum - root.val, list);
        }
        list.RemoveAt(list.Count-1);
    }
}
// @lc code=end

