/*
 * @lc app=leetcode id=427 lang=csharp
 *
 * [427] Construct Quad Tree
 */

// @lc code=start
/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/

public class Solution {
    public Node Construct(int[][] grid) {
        return Dfs(grid, 0,0, grid.Length);
    }

    private Node Dfs(int[][] grid, int r, int c, int len)
    {
        if (len == 1)
        {
            return new Node(grid[r][c] == 1, true);
        }

        var topLeft = Dfs(grid, r, c, len / 2);
        var topRight = Dfs(grid, r, c + len/2, len / 2);
        var bottomLeft = Dfs(grid, r+len/2, c, len/2);
        var bottomRight = Dfs(grid, r+len/2, c+len/2, len/2);

        if (topLeft.isLeaf && topRight.isLeaf && bottomLeft.isLeaf && bottomRight.isLeaf)
        {
            if (topLeft.val == topRight.val && topRight.val == bottomLeft.val && bottomLeft.val == bottomRight.val && bottomRight.val == topLeft.val)
            {
                return new Node(topLeft.val, true);
            }
        }
        return new Node(true, false, topLeft, topRight, bottomLeft, bottomRight);
    }
}
// @lc code=end

