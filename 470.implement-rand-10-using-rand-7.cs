/*
 * @lc app=leetcode id=470 lang=csharp
 *
 * [470] Implement Rand10() Using Rand7()
 */

// @lc code=start

using Microsoft.VisualBasic;

/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        var a = Rand7();
        var b = Rand7();
        var probs = (a-1) * 7 + (b-1);
        // if (probs >= 40) return Rand10();
        // else return (probs / 4) + 1;
        while (probs >= 40)
        {
            a = Rand7();
            b = Rand7();
            probs = (a-1) * 7 + (b-1);
        }
        return (probs / 4) + 1;
    }
}
// @lc code=end

