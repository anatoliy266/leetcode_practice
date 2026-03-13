/*
 * @lc app=leetcode id=173 lang=csharp
 *
 * [173] Binary Search Tree Iterator
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
public class BSTIterator
{
    private Stack<TreeNode> Stack = new Stack<TreeNode>();
    public BSTIterator(TreeNode root)
    {
        // var stack = new Stack<TreeNode>();
        // var curr = root;
        // while (stack.Count > 0 || curr != null)
        // {
        //     while (curr != null)
        //     {
        //         stack.Push(curr);
        //         curr = curr.right;
        //     }
        //     curr = stack.Pop();
        //     Stack.Push(curr);
        //     curr = curr.left;
        // }

        var curr = root;
        while (curr != null)
        {
            Stack.Push(curr);
            curr = curr.left;
        }
    }



    public int Next()
    {
        var el = Stack.Pop();
        if (el.right != null)
        {
            var c = el.right;
            while (c != null)
            {
                Stack.Push(c);
                c = c.left;
            }
        }
        return el.val;
    }

    public bool HasNext()
    {
        return Stack.Count > 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
// @lc code=end

