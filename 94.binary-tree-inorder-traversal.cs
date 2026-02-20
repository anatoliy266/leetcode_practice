/*
 * @lc app=leetcode id=94 lang=csharp
 *
 * [94] Binary Tree Inorder Traversal
 */

// @lc code=start

using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic;

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

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        // var res = new List<int>();
        // var treeStack = new Stack<TreeNode>();
        // var curr = root;
        // while(treeStack.Count > 0 || curr != null)
        // {
        //     while (curr != null)
        //     {
        //         treeStack.Push(curr);
        //         curr = curr.left;
        //     }
        //     curr = treeStack.Pop();
        //     res.Add(curr.val);
        //     curr = curr.right;
        // }
        // return res;
        if (root == null) return []; 
        return Dfs(root);
    }

    public List<int> Dfs(TreeNode root)
    {
        if (root.left == null && root.right == null) return new List<int>(){root.val};
        var leftArr = root.left == null? [] : Dfs(root.left);
        var rightArr = root.right == null ? [] : Dfs(root.right);
        leftArr.Add(root.val);
        leftArr.AddRange(rightArr);
        return leftArr;
    }
}
// @lc code=end

