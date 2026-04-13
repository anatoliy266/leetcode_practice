/*
 * @lc app=leetcode id=297 lang=csharp
 *
 * [297] Serialize and Deserialize Binary Tree
 */

// @lc code=start

using System.Text;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        var queue = new Queue<TreeNode>();
        var res = new StringBuilder();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var el = queue.Dequeue();
            if (el == null) {
                res.Append("n,"); // Маркер пустого узла
                continue;    // Пропускаем попытку взять детей у null
            }
            
            res.Append(el.val).Append(",");
            queue.Enqueue(el.left);
            queue.Enqueue(el.right);
        }
        return res.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        //"1 26 8736 51872638"
        var queueRes = new Queue<TreeNode>();
        var dataList = data.Split(",", StringSplitOptions.RemoveEmptyEntries);
        // var values = new Queue<string>(dataList);

        var f = dataList[0];
        if (f == "n") return null;
        var res = new TreeNode(int.Parse(f));
        queueRes.Enqueue(res);
        var i = 1;
        while (queueRes.Count > 0)
        {
            var el = queueRes.Dequeue();
            
            var l = dataList[i++];
            if (l != "n")
            {
                el.left = new TreeNode(int.Parse(l));
                queueRes.Enqueue(el.left);
            }
            
            var r = dataList[i++];
            if (r != "n")
            {
                el.right = new TreeNode(int.Parse(r));
                queueRes.Enqueue(el.right);
            }
        }
        return res;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
// @lc code=end

