/*
 * @lc app=leetcode id=331 lang=csharp
 *
 * [331] Verify Preorder Serialization of a Binary Tree
 */

// @lc code=start
public class Solution {
    public bool IsValidSerialization(string preorder) {
        var slots = 1;
        var items = preorder.Split(",", StringSplitOptions.RemoveEmptyEntries);

        for (var i = 0; i < items.Length; i++)
        {
            if (slots == 0) return false;
            if (items[i] == "#")
            {
                slots--;
            } else
            {
                slots++;
            }
            
        }
        return slots == 0;
    }
}
// @lc code=end

