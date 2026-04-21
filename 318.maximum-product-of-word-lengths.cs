/*
 * @lc app=leetcode id=318 lang=csharp
 *
 * [318] Maximum Product of Word Lengths
 */

// @lc code=start
public class Solution {
    public int MaxProduct(string[] words) {
        var maxProduct = 0;
        
        var masks = new int[words.Length];
        for (var i = 0; i < words.Length; i++)
        {
            foreach (char c in words[i])
            {
                masks[i] |= (1 << c - 'a');
            }
        }


        for (var i = 0; i< words.Length; i++)
        {
            for (var j = i+1; j < words.Length; j++)
            {
                if ((masks[i] & masks[j]) == 0 && maxProduct < words[i].Length * words[j].Length) 
                    maxProduct =  words[i].Length * words[j].Length;
            }
        }

        return maxProduct;
    }
}
// @lc code=end

