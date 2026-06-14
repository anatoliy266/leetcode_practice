/*
 * @lc app=leetcode id=437 lang=csharp
 *
 * [437] Path Sum III
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
    public int PathSum(TreeNode root, int targetSum)
    {
        var sums = new Dictionary<long, int>();
        return Dfs(root, targetSum, 0, sums);
    }

    public int Dfs(TreeNode node, int targetsum, long currentSum, Dictionary<long, int> sums)
    {

        if (node is null) return 0;
        var cnt = 0;

        // long currentSum = sums.Count > 0 ? sums.Last()+node.val : node.val;
        currentSum += node.val;


        if (currentSum == targetsum) cnt++;

        if (sums.TryGetValue(currentSum - targetsum, out int prefixCount)) 
        {
            cnt += prefixCount;
        }


        // for (var j = 0; j < sums.Count; j++)
        // {
        //     if (currentSum - sums[j] == targetsum) cnt++;
        // }

        if (sums.ContainsKey(currentSum)) sums[currentSum]++;
        else sums[currentSum] = 1;

        var l = Dfs(node.left, targetsum, currentSum, sums);
        var r = Dfs(node.right, targetsum, currentSum, sums);

        sums[currentSum]--;
        if (sums[currentSum] == 0) sums.Remove(currentSum);

        return cnt + l + r;
    }
}
// @lc code=end

