/*
 * @lc app=leetcode id=95 lang=csharp
 *
 * [95] Unique Binary Search Trees II
 */

// @lc code=start
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

// public class TreeNode
// {
//     public int val;
//     public TreeNode left;
//     public TreeNode right;
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//     {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }
public class Solution {
    public Dictionary<(int,int), List<TreeNode>> memo = new Dictionary<(int, int), List<TreeNode>>();
    public IList<TreeNode> GenerateTrees(int n) {
        return Dfs(1, n);
    }

    public List<TreeNode> Dfs(int start, int end)
    {
        if (start > end) return new List<TreeNode> { null };
        if (memo.ContainsKey((start,end))) return memo[(start,end)]; 
        var list = new List<TreeNode>();
        for (var i = start; i <= end; i++)
        {
            
            var lefts = Dfs(start, i-1);
            var rights = Dfs(i+1, end);

            foreach(var left in lefts)
            {
                foreach (var right in rights)
                {
                    var node = new TreeNode(i);
                    node.left = left;
                    node.right = right;
                    list.Add(node);
                }
            }
        }        
        memo[(start, end)] = list;
        return list;
    }
}
// @lc code=end

