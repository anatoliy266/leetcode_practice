/*
 * @lc app=leetcode id=449 lang=csharp
 *
 * [449] Serialize and Deserialize BST
 */

// @lc code=start
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
        if (root is null) return "";
        var list = new List<string>();

        list.Add(root.val.ToString());
        list.Add(serialize(root.left));
        list.Add(serialize(root.right));

        return string.Join(",", list);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if (data == "") return null;
        var list = data.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
        return Dfss(list, 0, 1, list.Count - 1);
    }

    private TreeNode Dfss(List<string> list, int center, int l, int r)
    {
        var node = new TreeNode(int.Parse(list[center]));
        if (l > r) return node;
        var c = l;
        while (c <= r && int.Parse(list[c]) < int.Parse(list[center])) c++;

        if (l <= c - 1) {
            node.left = Dfss(list, l, l + 1, c - 1);
        }
        
        if (c <= r) {
            node.right = Dfss(list, c, c + 1, r);
        }

        return node;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// String tree = ser.serialize(root);
// TreeNode ans = deser.deserialize(tree);
// return ans;
// @lc code=end

