/*
 * @lc app=leetcode id=102 lang=csharp
 *
 * [102] Binary Tree Level Order Traversal
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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        if (root == null) return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var lvlList = new List<int>();
            var lvl = queue.Count;
            for (var i = 0; i < lvl; i++)
            {
                var node = queue.Dequeue();
                lvlList.Add(node.val);

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            result.Add(lvlList);
        }
        return result;
        // var stack = new Stack<TreeNode>();
        // while (root != null || stack.Count > 0)
        // {
        //     while (root != null)
        //     {
        //         stack.Push(root);
        //         root = root.left;
        //     }
        //     var lvl =stack.Count();
        //     root = stack.Pop();
        //     if (!result.ContainsKey(lvl))
        //         result[lvl] = new List<int>() { root.val };
        //     else
        //         result[lvl].Add(root.val);

        //     root = root.right;
        // }
        // return result.Values.ToList();
    }
}
// @lc code=end

